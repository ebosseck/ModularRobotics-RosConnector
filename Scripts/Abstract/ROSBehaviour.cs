using Visus.Robotics.RosBridge;
using UnityEngine;

/// <summary>
/// Base Class already handling getting the connection to ROS
/// </summary>
namespace RosConnector.Abstract
{
    public class ROSBehaviour : MonoBehaviour
    {
        protected ROSConnection connection;
    
        /// <summary>
        /// Called on initialisation
        /// Gets or creates a new connection instance
        /// </summary>
        void Awake()
        {
            connection = ROSConnection.GetOrCreateInstance();
        }
    }
}