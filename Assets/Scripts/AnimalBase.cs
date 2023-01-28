using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum AnimalState {
    Walking,
    Attacking,
    Dead,
    Dropping,
}


public class AnimalBase : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    public float hp;
    public float power;
    public int maxAttackNum;
    public float normalY;
    public int attackRate;
    public float characost;
    //public float cost;

    public float speed;
    public bool isOpponent;
    public AnimalState state = AnimalState.Dropping;
    public bool IsDead = false;
   
    //GetComponentを用いてAnimatorコンポーネントを取り出す.
    public Animator animator;
    //あらかじめ設定していたintパラメーター「trans」の値を取り出す.
    //int trans;

    List<GameObject> opponentList;

    BoxCollider2D groundCollider;
    BoxCollider2D _collider;

    protected virtual void Start()
    {
        opponentList = new List<GameObject>();
        tag = "animal";
        groundCollider = GameObject.FindWithTag("ground").GetComponent<BoxCollider2D>();
        print(groundCollider);
        _collider = GetComponent<BoxCollider2D>();
        print(_collider);

        this.animator = GetComponent<Animator>();
        //animator = GetComponent<Animator>();
        //trans = animator.GetInteger("trans");

    }

    void Update()
    {
        switch (state) {
            case AnimalState.Dropping:
                Drop();
                break;
            case AnimalState.Walking:
                Walk();
                break;
            case AnimalState.Attacking:
                Attack();
                break;
        }

        



        // animator.SetInteger("trans", trans);

    }
    
        //cost = cost + 0.2;
        //scoreText.text = "SCORE: " + cost.ToString();
    

    public virtual void Die()
    {
        gameObject.SetActive(false);
        IsDead = true;
    }

    public virtual void Drop()
    {
        
        //float distance = Vector3.Distance(groundCollider.transform.position, _collider.transform.position);
        //if (Mathf.Abs(distance - normalY) < 10f)
        if (transform.position.y < normalY)
        {
            state = AnimalState.Walking;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
        }
        
    }

    public virtual void Walk()
    {
        transform.Translate(speed, 0, 0);
    }

    public virtual void Attack()
    {
        if (Time.frameCount % attackRate == 0)
        {
            int opponentNum = System.Math.Min(maxAttackNum, opponentList.Count);

            List<int> deadList = new List<int>();
            int attackCnt = 0;
            for (int i = 0; i < opponentList.Count; i++)
            {
                if (attackCnt >= opponentNum) break; 
                AnimalBase opponent = opponentList[i].GetComponent<AnimalBase>();

                if (opponent.IsDead)
                {
                    deadList.Add(i);
                    continue;
                }
                
                opponent.OnAttacked(power);
                attackCnt++;

                if (opponent.IsDead)
                {
                    deadList.Add(i);
                }
            }

            for (int i = 0; i < deadList.Count; i++)
            {
                opponentList.RemoveAt(deadList[i] - i);
            }

            if (opponentList.Count == 0)
            {
                print("to walk");
                state = AnimalState.Walking;
                //trans--;
            }

        }
    }

    public virtual void OnAttacked(float opponentPower) //死んだときはtrueを返す
    {
        hp -= opponentPower ;
        print($"攻撃！, {name}に{opponentPower}のダメージ");
        if (hp <= 0)
        {
            Die();
            print($"{name}は死んだ");
        }
    }

    //タグ"animal"のcllider持ちと接触時発動
    void OnTriggerEnter2D(Collider2D collision)
    {
        print("collision!");
        if (collision.gameObject.CompareTag("animal"))
        {
            if (collision.gameObject.GetComponent<AnimalBase>().isOpponent != isOpponent)
            {
                print("start attack");
                // this.speed = 0f;
                state = AnimalState.Attacking;
                animator.SetTrigger("attack");
                //trans++;
                opponentList.Add(collision.gameObject);
            }
        }
    }
}
