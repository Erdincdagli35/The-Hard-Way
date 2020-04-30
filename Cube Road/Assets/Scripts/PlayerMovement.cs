using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rB;//Bu değişken Rigibody bileşinden çağırılıp tanımlanmıştır    
    public float forwardForce = 2000f;//İleri şiddet değişkenini tanınmladık
    public float sideWayForce = 500f;
	//Fizik le birlikte çalışacağımız için FixedUpdate yapısını kullandık.
	void FixedUpdate () {
        rB.AddForce(0, 0, forwardForce*Time.deltaTime);//Z ekseninde zaman paramtresine göre artış gösterilerek hızlanacaktır.
        if (Input.GetKey("d"))
        {
            rB.AddForce(sideWayForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rB.AddForce(-sideWayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (rB.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
