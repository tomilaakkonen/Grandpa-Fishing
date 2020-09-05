using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour {

    private AIFish m_AIManager;

    private bool m_hasTarget = false;
    private bool m_isTurning;

    private Vector3 m_wayPoint;
    private Vector3 m_lastWaypoint = new Vector3(0f, 0f, 0f);

    //private Animator m_animator;
    private float m_speed;

	// Use this for initialization
	void Start () {
        m_AIManager = transform.parent.GetComponentInParent<AIFish>();
        //m_animator = GetComponent<Animator>();

        SetUpNPC();
	}

    void SetUpNPC()
    {
        float m_scale = Random.Range(0f, 0f);
        transform.localScale += new Vector3(m_scale * 1.5f, m_scale, 0f);
    }
	// Update is called once per frame
	void Update () {
		if (!m_hasTarget)
        {
            m_hasTarget = CanFindTarget();
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, m_wayPoint, m_speed * Time.deltaTime);
        }

        if (transform.position == m_wayPoint)
        {
            m_hasTarget = false;
        }
	}

    bool CanFindTarget(float start = 1f, float end = 7f)
    {
        m_wayPoint = m_AIManager.RandomWaypoint();

        if(m_lastWaypoint == m_wayPoint)
        {
            m_wayPoint = m_AIManager.RandomWaypoint();
            return false;
        }
        else
        {
            m_lastWaypoint = m_wayPoint;
            m_speed = Random.Range(start, end);
            //m_animator.speed = m_speed;
            return true;
        }
    }
}
