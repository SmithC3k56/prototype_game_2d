using UnityEngine;
using UnityEngine.UI;

public class MiniMap : MonoBehaviour
{
    public Camera mainCamera;               // Reference to the main camera
    public Camera miniMapCamera;            // Reference to the mini-map camera
    public RenderTexture miniMapTexture;    // Render texture for the mini-map
    public RawImage miniMapRawImage;        // Reference to the RawImage component displaying the mini-map texture
    public Transform player;

    // Reference to the RawImage component representing obstacles
    public float miniMapSize = 200f;           // Size of the mini-map in pixels
    public float obstacleMarkerSize = 10f;
    //private void Start()
    //{
    //    // Set the target texture of the mini-map camera
    //    miniMapCamera.targetTexture = miniMapTexture;
    //}

    //private void LateUpdate()
    //{
    //    // Update the mini-map texture based on the main camera's position and rotation
    //    UpdateMiniMap();

    //    // Update the position of the obstacle marker on the mini-map
    //    UpdateObstacleMarker();

    //}

    //private void UpdateMiniMap()
    //{
    //    // Get the position of the player
    //    Vector3 playerPosition = player.position;

    //    // Set the position of the mini-map camera to follow the player's position
    //    miniMapCamera.transform.position = new Vector3(playerPosition.x, miniMapCamera.transform.position.y, playerPosition.z);

    //    // Get the position of the main camera in the world space
    //    Vector3 cameraPosition = mainCamera.transform.position;

    //    // Convert the world position to the mini-map texture space
    //    Vector3 miniMapPosition = new Vector3(cameraPosition.x / 100f, cameraPosition.z / 100f, 0f);

    //    // Set the position of the mini-map icon on the RawImage component
    //    //miniMapRawImage.rectTransform.anchoredPosition = miniMapPosition;

    //    // Get the rotation of the main camera in the world space
    //    Quaternion cameraRotation = mainCamera.transform.rotation;

    //    // Set the rotation of the mini-map icon on the RawImage component
    //    //miniMapRawImage.rectTransform.rotation = Quaternion.Euler(0f, 0f, -cameraRotation.eulerAngles.y);
    //}

    //private void UpdateObstacleMarker()
    //{
    //    // Get the position of the player
    //    Vector3 playerPosition = player.position;

    //    // Convert the player's position to the screen space
    //    Vector3 playerScreenPosition = miniMapCamera.WorldToScreenPoint(playerPosition);

    //    // Calculate the position of the obstacle marker on the mini-map
    //    Vector2 obstacleMarkerPosition = new Vector2(playerScreenPosition.x - (Screen.width - miniMapSize) / 2f, playerScreenPosition.y - (Screen.height - miniMapSize) / 2f);

    //    // Set the position of the obstacle marker on the mini-map
    //    //miniMapRawImage.rectTransform.anchoredPosition = obstacleMarkerPosition;

    //    // Set the size of the obstacle marker
    //    //miniMapRawImage.rectTransform.sizeDelta = new Vector2(obstacleMarkerSize, obstacleMarkerSize);
    //}
}
