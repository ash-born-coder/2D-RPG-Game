using UnityEngine;

public class Enemy : Player
{

    private bool playerDetected;

    protected override bool TriggersGameOver => false;

    protected override void Update()
    {
        HandleCollision();
        HandleAnimation();
        HandleMovement();
        HandleFlip();
        HandleAttack();
    }

    protected override void HandleAttack()
    {
        if (playerDetected)
        {
            anim.SetTrigger("attack");
        }
    }

    protected override void HandleMovement()
    {
        if (canMove == true)
        {
            rb.linearVelocity = new Vector2(facingDir * moveSpeed, rb.linearVelocity.y);
        }
        else
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);

        }
    }

    protected override void HandleCollision()
    {
        base.HandleCollision();

        playerDetected = Physics2D.OverlapCircle(attackPoint.position, attackRadius, whatIsTarget);
    }

    protected override void Die()
    {
        base.Die();
        UI.instance.AddKillCount();
    }
}
