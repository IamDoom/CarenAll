
import './App.css';
import { store } from "./Actions/store";
import { Provider } from "react-redux";
import DCandidates from './componnents/DCandidates';
import { Container } from '@mui/material'; 
import {ToastProvider} from "react-toast-notifications";

function App() {
    return (
        <Provider store={store}>
            <ToastProvider autoDismiss={true}>
            <Container maxWidth="lg">
                <DCandidates/>
            </Container>
        </ToastProvider>
        </Provider>
    );
};


export default App;
