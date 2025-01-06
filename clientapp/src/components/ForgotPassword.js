import React from 'react';
import '/wwwroot/css/authStyles.css';

function ForgotPassword({ onBack }) {
    return (
        <div className="auth-container">
            <h2>Forgot Password</h2>
            <form className="auth-form">
                <div>
                    <label htmlFor="email">Enter your email:</label>
                    <input type="email" id="email" name="email" />
                </div>
                <button className="submit" type="submit">Submit</button>
            </form>
            <button type="button" className="secondary" onClick={onBack}>
                Back to Login
            </button>
        </div>
    );
}

export default ForgotPassword;