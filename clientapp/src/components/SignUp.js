import React from 'react';
import './authStyles.css'; // Import the CSS file

function SignUp({ onBack }) {
    return (
        <div className="auth-container">
            <h2>Sign Up</h2>
            <form className="auth-form">
                <div>
                    <label htmlFor="username">Username:</label>
                    <input type="text" id="username" name="username" />
                </div>
                <div>
                    <label htmlFor="email">Email:</label>
                    <input type="email" id="email" name="email" />
                </div>
                <div>
                    <label htmlFor="password">Password:</label>
                    <input type="password" id="password" name="password" />
                </div>
                <button type="submit">Sign Up</button>
            </form>
            <button type="button" className="secondary" onClick={onBack}>
                Back to Login
            </button>
        </div>
    );
}

export default SignUp;