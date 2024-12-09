import React, { useState, useEffect } from "react";
import * as actions from "../Actions/dCandidate";
import { connect } from 'react-redux';
import { Grid, TextField, Button } from "@mui/material";
import useForm from "./useForm";
import { withStyles } from "@mui/styles";
import { useToasts } from "react-toast-notifications";

const styles = theme => ({
    root: {
        '& .MuiTextField-root': {
            margin: 1,
            minWidth: 230,
        }
    },
    smMargin: {
        margin: 18
    }
});

const initialFieldValues = {
    bedrijfsNaam: '',
    kvkNummer: '',
    email: '',
    address: ''
};

const DCandidateForm = ({ classes, ...props }) => {
    const { addToast } = useToasts();

    const validate = (fieldValues = values) => {
        let temp = { ...errors };
        if ('bedrijfsNaam' in fieldValues)
            temp.bedrijfsNaam = fieldValues.bedrijfsNaam ? "" : "Verplicht";
        if ('kvkNummer' in fieldValues)
            temp.kvkNummer = fieldValues.kvkNummer ? "" : "Verplicht";
        if ('email' in fieldValues)
            temp.email = (/^$|.+@.+..+/).test(fieldValues.email) ? "" : "Email is niet valid";
        setErrors({
            ...temp
        });
        if (fieldValues === values)
            return Object.values(temp).every(x => x === "");
    };

    const {
        values,
        setValues,
        errors,
        setErrors,
        resetForm,
        handleInputChange
    } = useForm(initialFieldValues, validate);

    const handleSubmit = e => {
        e.preventDefault();
        if (validate()) {
            if (props.currentId === 0)
                props.createDCandidate(values, () => { window.alert('inserted') });
            else
                props.updateDCandidate(props.currentId, values, () => { window.alert('update') });
        }
    };

    useEffect(() => {
        if (props.currentId !== 0) {
            setValues({
                ...props.dCandidateList.find(x => x.id === props.currentId)
            });
            setErrors({});
        }
    }, [props.currentId]);

    return (
        <form autoComplete="off" noValidate className={classes.root} onSubmit={handleSubmit}>
            <Grid container>
                <Grid item xs={6}>
                    <TextField
                        name="bedrijfsNaam"
                        variant="outlined"
                        label="Bedrijfs Naam"
                        value={values.bedrijfsNaam || ''}
                        onChange={handleInputChange}
                        {...(errors.bedrijfsNaam && { error: true, helperText: errors.bedrijfsNaam })}
                    />
                    <TextField
                        name="email"
                        variant="outlined"
                        label="Bedrijfs Email"
                        value={values.email || ''}
                        onChange={handleInputChange}
                        {...(errors.email && { error: true, helperText: errors.email })}
                    />
                </Grid>
                <Grid item xs={6}>
                    <TextField
                        name="kvkNummer"
                        variant="outlined"
                        label="KVK-Nummer"
                        value={values.kvkNummer || ''}
                        onChange={handleInputChange}
                        {...(errors.kvkNummer && { error: true, helperText: errors.kvkNummer })}
                    />
                    <TextField
                        name="address"
                        variant="outlined"
                        label="Address"
                        value={values.address || ''}
                        onChange={handleInputChange}
                        {...(errors.address && { error: true, helperText: errors.address })}
                    />
                    <div>
                        <Button
                            variant="contained"
                            color="primary"
                            type="submit"
                            className={classes.smMargin}
                        >
                            Submit
                        </Button>
                        <Button
                            variant="contained"
                            className={classes.smMargin}
                            onClick={resetForm}
                        >
                            Reset
                        </Button>
                    </div>
                </Grid>
            </Grid>
        </form>
    );
};

const mapStateToProps = state => ({
    dCandidateList: state.dCandidate.list
});

const mapActionToProps = {
    createDCandidate: actions.create,
    updateDCandidate: actions.update
};

export default connect(mapStateToProps, mapActionToProps)(withStyles(styles)(DCandidateForm));
