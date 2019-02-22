using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pisteet: MonoBehaviour
{
    //public Text pisteTeksti;
    
    public Text voittoteksti;
    public Text tulostaulu;
    public GameObject tulostauluObjekti;
    public GameObject voittotekstiObjekti;
    // public GameObject kakka;

    public int eritelikaPiste;
    public int tayttoPiste;
    public int pintalikaPiste;
    public int ponttoLikaPiste;
    public int lattialikaPiste;
    public int valinePiste;
    public int roskaPiste;
    public int piste;

 int alku_eritelikaPiste = 100;
 int alku_tayttoPiste;
 int alku_pintalikaPiste = 100;
 int alku_ponttoLikaPiste = 100;
 int alku_lattialikaPiste = 100;
 int alku_valinePiste;
 int alku_roskaPiste;

    /*public Sprite eritelianPoistoTyhja;
    public Sprite lattianPuhdistusTyhja;
    public Sprite pintojenSiivousTyhja;
    public Sprite pontonSiivousTyhja;
    public Sprite taytotJaVaihdotTyhja;
    public Sprite valineidenHuoltoTyhja;

    public Sprite eritelianPoistoTehty;
    public Sprite lattianPuhdistusTehty;
    public Sprite pintojenSiivousTehty;
    public Sprite pontonSiivousTehty;
    public Sprite taytotJaVaihdotTehty;
    public Sprite valineidenHuoltoTehty;*/

    public GameObject kanvaasi;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    //public Renderer;

   

    public int index = 0;

    Image eritelianPoistoTyhja;
    Image lattianPuhdistusTyhja;
    Image pintojenSiivousTyhja;
    Image pontonSiivousTyhja;
    Image taytotJaVaihdotTyhja;
    Image valineidenHuoltoTyhja;

    public bool eritelianPoistoValmis = false;
    public bool lattianPuhdistusValmis = false;
    public bool pintojenSiivousValmis = false;
    public bool pontonSiivousValmis = false;
    public bool taytotJaVaihdotValmis = false;
    public bool valineidenhuoltoValmis = false;

    // Start is called before the first frame update
    void Start()
    {
        voittoteksti.text = voittotekstiObjekti.GetComponent<TextMesh>().text;
        tulostaulu.text = tulostauluObjekti.GetComponent<TextMesh>().text;
        voittotekstiObjekti.SetActive(false);
        alku_eritelikaPiste = GameObject.FindGameObjectsWithTag("eriteLika").Length;
        alku_pintalikaPiste = GameObject.FindGameObjectsWithTag("pintaLika").Length;
        alku_ponttoLikaPiste = GameObject.FindGameObjectsWithTag("ponttoLika").Length;
        alku_lattialikaPiste = GameObject.FindGameObjectsWithTag("lattiaLika").Length;
        tayttoPiste = 0;
        valinePiste = 0;
    }

    void Update()
    {
        //spriteRenderer.sprite = sprites[index];
        PaivitaTulostaulu();
        eritelikaPiste = GameObject.FindGameObjectsWithTag("eriteLika").Length;
        pintalikaPiste = GameObject.FindGameObjectsWithTag("pintaLika").Length;
        ponttoLikaPiste = GameObject.FindGameObjectsWithTag("ponttoLika").Length;
        lattialikaPiste = GameObject.FindGameObjectsWithTag("lattiaLika").Length;
        valinePiste = GameObject.FindGameObjectsWithTag("valinePiste").Length;
        roskaPiste = GameObject.FindGameObjectsWithTag("roska").Length;
        piste = (alku_eritelikaPiste - eritelikaPiste) + (alku_pintalikaPiste - pintalikaPiste) + (alku_ponttoLikaPiste - ponttoLikaPiste) + (alku_lattialikaPiste - lattialikaPiste);
    }

    // Update is called once per frame
    void ajastin()
    {

        //Debug.Log(piste);

    }
    
    void PaivitaTulostaulu()
    {
        //tulostaulu.text = piste.ToString();

        if (eritelikaPiste < 1)
        {
            voittotekstiObjekti.gameObject.SetActive(true);
            Debug.Log("Eritesiivottu");
            
            GameObject.Find("eritelianPoistoTyhja_0").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("eritelianPoistoTehty");
        }

        if (lattialikaPiste < 1)
        {
            voittotekstiObjekti.gameObject.SetActive(true);
            Debug.Log("lattiasiivottu");
            GameObject.Find("lattianPuhdistusTyhja_0").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("lattianPuhdistusTehty"); 
        }

        if (pintalikaPiste < 1)
        {
            voittotekstiObjekti.gameObject.SetActive(true);
            GameObject.Find("pintojenSiivousTyhja_0").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pintojenSiivousTehty"); 
        }

        if (ponttoLikaPiste < 1)
        {
            voittotekstiObjekti.gameObject.SetActive(true);
            Debug.Log("ponttosiivottu");
            GameObject.Find("pontonSiivousTyhja_0").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pontonSiivousTehty"); 
        }

        if (tayttoPiste > 62)
        {
            voittotekstiObjekti.gameObject.SetActive(true);
            GameObject.Find("taytotJaVaihdotTyhja_0").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("taytotJaVaihdotTehty"); 
        }

        if (valinePiste > 10)
        {
            voittotekstiObjekti.gameObject.SetActive(true);
            GameObject.Find("valineidenHuoltoTyhja_0").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("valineidenHuoltoTehty"); 
        }
    }

}
