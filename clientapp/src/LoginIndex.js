import React, { useState } from 'react';
import ReactDOM from 'react-dom';
import Login from './components/Login';
import SignUp from './components/SignUp';
import ForgotPassword from './components/ForgotPassword';

function App() {
    const [currentView, setCurrentView] = useState('login');

    return (
        <div>
            {currentView === 'login' && <Login onChangeView={setCurrentView} />}
            {currentView === 'signup' && <SignUp onBack={() => setCurrentView('login')} />}
            {currentView === 'forgotPassword' && (
                <ForgotPassword onBack={() => setCurrentView('login')} />
            )}
        </div>
    );
}

ReactDOM.render(<App />, document.getElementById('react-root-login'));