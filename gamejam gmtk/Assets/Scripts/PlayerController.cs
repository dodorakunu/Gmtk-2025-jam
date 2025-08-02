using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float moveForce = 50f;
    public float maxSpeed = 5f;
    public float jumpForce = 6f;
    public float mouseSensitivity = 3f;


    [SerializeField] float bobAmount = 0.05f;
    [SerializeField] float bobSpeed = 8f;

    private float bobTimer = 0f;
    private Vector3 camStartLocalPos;




    public Transform cameraHolder;

    private Rigidbody rb;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        Move();
    }

    void Update()
    {
        Rotate();
        Jump();
        HeadBob();
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 inputDir = new Vector3(h, 0, v).normalized;
        Vector3 moveDir = cameraHolder.TransformDirection(inputDir);
        moveDir.y = 0;

        if (rb.velocity.magnitude < maxSpeed)
            rb.AddForce(moveDir * moveForce);
    }

    void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0f, mouseX, 0f);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    void HeadBob()
    {
        Vector3 flatVelocity = rb.velocity;
        flatVelocity.y = 0;

        if (flatVelocity.magnitude > 0.1f && isGrounded)
        {
            bobTimer += Time.deltaTime * bobSpeed;
            float newY = camStartLocalPos.y + Mathf.Sin(bobTimer) * bobAmount;
            Vector3 newPos = new Vector3(camStartLocalPos.x, newY, camStartLocalPos.z);
            cameraHolder.localPosition = newPos;
        }
        else
        {
            // Yavaþça baþlangýç pozisyonuna dön
            cameraHolder.localPosition = Vector3.Lerp(cameraHolder.localPosition, camStartLocalPos, Time.deltaTime * 5f);
            bobTimer = 0f;
        }
    }

void OnCollisionStay(Collision collision)
    {
        foreach (var contact in collision.contacts)
        {
            if (Vector3.Dot(contact.normal, Vector3.up) > 0.5f)
            {
                isGrounded = true;
                return;
            }
        }
        isGrounded = false;
    }

    void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
