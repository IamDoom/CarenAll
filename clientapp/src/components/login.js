import React, { useState } from 'react';
import SignUp from './SignUp';
import ForgotPassword from './ForgotPassword';
import './authStyles.css'; // Import the CSS file

function Login() {
    // State to track which form is displayed
    const [currentView, setCurrentView] = useState('login');

    // Render different components based on the state
    return (
        <div className="auth-container">
            {currentView === 'login' && (
                <>
                    <h2>Login</h2>
                    <form className="auth-form">
                        <div>
                            <label htmlFor="username">Username:</label>
                            <input type="text" id="username" name="username" />
                        </div>
                        <div>
                            <label htmlFor="password">Password:</label>
                            <input type="password" id="password" name="password" />
                        </div>
                        <button type="submit">Log In</button>
                    </form>
                    <div className="auth-button-group">
                        <button
                            type="button"
                            className="secondary"
                            onClick={() => setCurrentView('forgotPassword')}
                        >
                            Forgot Password?
                        </button>
                        <button
                            type="button"
                            className="secondary"
                            onClick={() => setCurrentView('signup')}
                        >
                            Sign Up
                        </button>
                    </div>
                </>
            )}

            {currentView === 'signup' && <SignUp onBack={() => setCurrentView('login')} />}
            {currentView === 'forgotPassword' && (
                <ForgotPassword onBack={() => setCurrentView('login')} />
            )}
        </div>
    );
}

export default Login;