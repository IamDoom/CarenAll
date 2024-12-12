import React, { useState } from 'react'
import '/wwwroot/css/autnhStyles.css'

function SignUp({ onback }) {
    const [selectedType, setSelectedType] = useState('particulier');
    const [formData, setFormData] = useState({
        username: '',
        email: '',
        phone: '',
        address: '',
        password: ''
    })
}