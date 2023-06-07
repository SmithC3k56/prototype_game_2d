using UnityEngine;

public class AIPlayerController : MonoBehaviour
{
    public float moveSpeed = 3f; // Speed of the AI player's movement
    public float detectionRadius = 5f; // Radius to detect nearby items
    public LayerMask itemLayer; // Layer mask for items

    private Transform targetItem; // Reference to the target item to move towards
    private bool isSearching; // Flag to indicate if the AI player is searching for an item
    private Vector3 searchDirection; // Direction to move when searching

    public Graph graph; // Reference to the graph representing the shape

    private GraphNode targetNode;

    private void Start()
    {
        // Initialize search direction to a random direction
        searchDirection = Random.insideUnitCircle.normalized;
    }

    private void Update()
    {
        if (targetItem == null && !isSearching)
        {
            // Detect nearby items
            Collider2D[] nearbyItems = Physics2D.OverlapCircleAll(transform.position, detectionRadius, itemLayer);

            // Find the nearest item
            float nearestDistance = Mathf.Infinity;
            foreach (Collider2D item in nearbyItems)
            {
                float distance = Vector2.Distance(transform.position, item.transform.position);
                if (distance < nearestDistance)
                {
                    nearestDistance = distance;
                    targetItem = item.transform;
                }
            }

            // If no item found, start searching
            if (targetItem == null)
            {
                StartSearching();
            }
        }

        // Move towards the target item if it exists
        if (targetItem != null)
        {
            Vector3 direction = (targetItem.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;

            // Check if the AI player has reached the target item
            float distanceToTarget = Vector2.Distance(transform.position, targetItem.position);
            if (distanceToTarget < 0.1f)
            {
                //ConsumeItem();
                targetNode = GetNextNode(targetNode);

            }
        }
        else if (isSearching)
        {
            //targetNode = GetNextNode(targetNode);
            // Move in the search direction
            //transform.position += searchDirection * moveSpeed * Time.deltaTime;
        }
    }
    private GraphNode GetNextNode(GraphNode currentNode)
    {
        // Randomly select one of the neighboring nodes as the next target
        if (currentNode.neighbors.Count > 0)
        {
            int randomIndex = Random.Range(0, currentNode.neighbors.Count);
            return currentNode.neighbors[randomIndex];
        }

        return null;
    }
    private void StartSearching()
    {
        // Set the search direction to a random direction
        searchDirection = Random.insideUnitCircle.normalized;
        isSearching = true;
    }

    private void ConsumeItem()
    {
        // TODO: Implement the logic to consume the item

        // Destroy the consumed item
        Destroy(targetItem.gameObject);

        // Clear the target item
        targetItem = null;

        // Stop searching and resume normal behavior
        isSearching = false;
    }

    private void OnDrawGizmosSelected()
    {
        // Draw detection radius in editor
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Item"))
        {
            //// Increase the player's size
            //gameObject.transform.localScale += new Vector3(sizeIncreaseAmount, this.sizeIncreaseAmount, 0f);
            //// Increase the score
            //scoreData.score++;

            // Remove the item object
            Destroy(collision.gameObject);
            //Debug.Log("Touched");
            // Add any other desired logic, such as updating score or playing a sound effect
        }
    }
}
