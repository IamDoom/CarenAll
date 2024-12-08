import React, { useState } from 'react';
import ReactDOM from 'react-dom';
import Login from './components/Login';
import SignUp from './components/SignUp';
import ForgotPassword from './components/ForgotPassword';

function App() {
    const [currentView, setCurrentView] = useState('login');
    const [errorMessage, setErrorMessage] = useState('');

    const setError = (message) => {
        setErrorMessage(message);
    };

    return (
        <div className="auth-container">
            {currentView === 'login' && <Login onChangeView={setCurrentView} setError={setError} />}
            {currentView === 'signup' && <SignUp onBack={() => setCurrentView('login')} setError={setError} />}
            {currentView === 'forgotPassword' && (
                <ForgotPassword onBack={() => setCurrentView('login')} setError={setError} />
            )}

            {errorMessage && <div className="error-message">{errorMessage}</div>}  {/* Display any errors */}
        </div>
    );
}

ReactDOM.render(<App />, document.getElementById('react-root-login'));