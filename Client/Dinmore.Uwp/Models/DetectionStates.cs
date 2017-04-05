﻿namespace Dinmore.Uwp.Models
{
    /// <summary>
    /// Values for identifying and controlling the current step of detection.
    /// </summary>
    public enum DetectionStates
    {
        /// <summary>
        /// Camera is off and app is either starting up or shutting down.
        /// </summary>
        Idle,

        /// <summary>
        /// Webcam is running and looking for faces.
        /// </summary>
        WaitingForFaces,

        /// <summary>
        /// At least one face has been detected by the IoT device.
        /// </summary>
        FaceDetectedOnDevice,

        /// <summary>
        /// Call to API has been made and now waiting for response or timeout.
        /// </summary>
        WaitingForApiResponse,
    }
}
