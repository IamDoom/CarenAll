import React, { useEffect, useState } from "react";


const LeaseRequestForm = () => {
    const [formData, setFormData] = useState({
        startDate: "",
        endDate: "",
        reason: "",
        expectedDistance: "",
    });

    function showLeaseRequestForm() {
        
        const dynamicContent = document.getElementById('dynamic-content');
        ReactDOM.render(<LeaseRequestForm />, dynamicContent);
    }