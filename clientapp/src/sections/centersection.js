import React, { useState, useEffect } from "react";

const CenterSection = () => {
    const [currentView, setCurrentView] = useState("default");
    const [selectedRequestId, setSelectedRequestId] = useState(null);

    useEffect(() => {
        const handleUpdate = (event) => {
            setCurrentView(event.detail.view);
            if (event.detail.requestId) {
                setSelectedRequestId(event.detail.requestId);
            }
        };

        window.addEventListener("updateCenterSection", handleUpdate);
        return () => window.removeEventListener("updateCenterSection", handleUpdate);
    }, []);

    const renderContent = () => {
        switch (currentView) {
            case "leaseRequestForm":
                return <LeaseRequestForm />;
            case "evaluateRequestForm":
                return <EvaluateRequestForm requestId={selectedRequestId} />;
            case "messages":
                return <div><h3>Messages</h3><p>You have no new messages.</p></div>;
            case "changeStatus":
                return <div><h3>Change Status</h3><p>Change your account status here.</p></div>;
            default:
                return <p>Select an action to display content here.</p>;
        }
    };

    return (
        <div className="center-section-content">
            {renderContent()}
        </div>
    );
};

export default CenterSection;