import React, { useState, useEffect } from "react";
import { connect } from 'react-redux';
import * as actions from "../Actions/dCandidate";
import { Grid, Paper, TableContainer, Table, TableHead, TableRow, TableCell, TableBody } from "@mui/material";
import { withStyles } from "@mui/styles";
import DCandidateForm from './DCandidateForm';
import { Button } from "@mui/material";
import { ButtonGroup } from "@mui/material";
import EditIcon from "@mui/icons-material/Edit";
import DeleteIcon from "@mui/icons-material/Delete";
import { useToasts } from "react-toast-notifications";





const styles = theme => ({
    root: {
        "& .MuilTableCell-head": {
            fontSize: "1.25 rem"
        }
    },
    paper: {
        margin: 8,
        padding: 8
    }

})


const DCandidates = ({classes, ...props}) => {
    const [currentId, setCurrentId] = useState(0);



    useEffect(() => {
        //props.fetchAllDCandidates()
        console.log("Candidate List:", props.dCandidateList);

        
    }, [])

    const { addToast } = useToasts();

    const onDelete = id => {
        if (window.confirm('are you sure'))
        props.deleteDCandidate(id, () => addToast("Deleted succesfully", {appearance: 'info'}))
    }




    return (
        <Paper className={classes.paper} elevation={ 3}>
            <Grid container>
                <Grid item xs={6}>
                    <DCandidateForm {...({currentId, setCurrentId})} />
                </Grid>
                <Grid item xs={6}>
                    <TableContainer>
                        <Table>
                            <TableHead className={classes.root}>
                                <TableRow>
                                    <TableCell>Bedrijfs Naam</TableCell>
                                    <TableCell>KVK-Nummer</TableCell>
                                   
                                    <TableCell></TableCell>
                                </TableRow>
                            </TableHead>
                            <TableBody>
                                {
                                    props.dCandidateList.map((record, index) => (
                                    <TableRow key={index} hover>
                                    <TableCell>{record.bedrijfsNaam}</TableCell>
                                    <TableCell>{record.kvkNummer}</TableCell>
                                 
                                            <TableCell>
                                                <ButtonGroup variant="text">
                                                    <Button><EditIcon color="primary"
                                                        onClick={() => { setCurrentId(record.id) }} /></Button>
                                                    <Button><DeleteIcon color="second" onClick = {() => onDelete(record.id)} /></Button>
                                                </ButtonGroup>


                                     </TableCell>
                                </TableRow>
                                        ))}
                            </TableBody>
                        </Table>
                    </TableContainer>
                </Grid>
            </Grid>
        </Paper>
    );
};

const mapStateToProps = state => ({
    dCandidateList: state.dCandidate.list
});

const mapActionToProps = {
    fetchAllDCandidates: actions.fetchAll,
    deleteDCandidate: actions.DELETE
}


export default connect(mapStateToProps, mapActionToProps)(withStyles(styles) (DCandidates));
