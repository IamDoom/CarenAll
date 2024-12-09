import api from "./api";


export const ACTION_TYPES = { 
    CREATE: 'CREATE',
    UPDATE: 'UPDATE',
    DELETE: 'DELETE',
    FETCH_ALL: 'FETCH_ALL'
}

const formateData = data => ({
    ...data,
    age:parseInt(data.age?data.age:0)

})

export const fetchAll = () => dispatch => {
    api.dCandidate().fetchAll()
        .then(
            response => {
                
                dispatch({
                    type: ACTION_TYPES.FETCH_ALL,
                    payload: response.data
                })
            }

    )
   


}

export const create = (data, onSuccess) => dispatch => {
    data = formateData(data)
    api.dCandidate().create(data)
        .then(res => {
            dispatch({
                type: ACTION_TYPES.CREATE,
                payload: res.data
            })
            
        })

        .catch(err => console.log(err));
}
export const update = (id, data, onSuccess) => dispatch => {
    data = formateData(data)
    api.dCandidate().update(id, data)
        .then(res => {
            dispatch({
                type: ACTION_TYPES.UPDATE,
                payload: {id, ...data}
            })
                
        })

        .catch(err => console.log(err));
}

export const DELETE = (id, data, onSuccess) => dispatch => {
    data = formateData(data)
    api.dCandidate().DELETE(id,data)
        .then(res => {
            dispatch({
                type: ACTION_TYPES.DELETE,
                payload: id
            })
                
        })
        .catch(err => console.log(err));
}
