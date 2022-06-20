using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveCookings : MonoBehaviour
{
    public GameObject image1, image2, image3, image4, image5, image6, image7, image8, image9, 
    flagAngola, flagBrasil, flagMocambique;

    Vector2 imageInicioPos1, imageInicioPos2, imageInicioPos3, imageInicioPos4, imageInicioPos5, 
    imageInicioPos6, imageInicioPos7, imageInicioPos8, imageInicioPos9;

    public AudioSource audioSound;
    public AudioClip[] soundCooking;

    float timer = 0.0f;
    int seconds = 0;

    [SerializeField]
    public Text contadorAngolaText, contadorBrasilText, contadorMocambiqueText;
    private int contadorAngola, contadorBrasil, contadorMocambique;

    void Start(){
        contadorAngola = 0;
        contadorBrasil = 0;
        contadorMocambique = 0;
        audioSound = gameObject.GetComponent<AudioSource>();

        imageInicioPos1 = image1.transform.position;
        imageInicioPos2 = image2.transform.position;
        imageInicioPos3 = image3.transform.position;
        imageInicioPos4 = image4.transform.position;
        imageInicioPos5 = image5.transform.position;
        imageInicioPos6 = image6.transform.position;
        imageInicioPos7 = image7.transform.position;
        imageInicioPos8 = image8.transform.position;
        imageInicioPos9 = image9.transform.position;
    }

    // Movimentação dos objetos
    public void DragImage1(){
        image1.transform.position = Input.mousePosition;
    }

    public void DragImage2(){
        image2.transform.position = Input.mousePosition;
    }

    public void DragImage3(){
        image3.transform.position = Input.mousePosition;
    }

    public void DragImage4(){
        image4.transform.position = Input.mousePosition;
    }

    public void DragImage5(){
        image5.transform.position = Input.mousePosition;
    }

    public void DragImage6(){
        image6.transform.position = Input.mousePosition;
    }

    public void DragImage7(){
        image7.transform.position = Input.mousePosition;
    }

    public void DragImage8(){
        image8.transform.position = Input.mousePosition;
    }

    public void DragImage9(){
        image9.transform.position = Input.mousePosition;
    }

    // Colocar as culinárias nas bandeiras
    public void DropImage1(){
        float Distance = Vector3.Distance(image1.transform.position, flagAngola.transform.position);
        if (Distance < 100){
            image1.transform.position = flagAngola.transform.position;
            audioSound.clip = soundCooking[0];
            audioSound.Play();
            contadorAngola += 1;
        }else{
            image1.transform.position = imageInicioPos1;
        }
    }

    public void DropImage2(){
        float Distance = Vector3.Distance(image2.transform.position, flagAngola.transform.position);
        if (Distance < 100){
            image2.transform.position = flagAngola.transform.position;
            audioSound.clip = soundCooking[1];
            audioSound.Play();
            contadorAngola += 1;
        }else{
            image2.transform.position = imageInicioPos2;
        }
    }

    public void DropImage3(){
        float Distance = Vector3.Distance(image3.transform.position, flagBrasil.transform.position);
        if (Distance < 100){
            image3.transform.position = flagBrasil.transform.position;
            audioSound.clip = soundCooking[2];
            audioSound.Play();
            contadorBrasil += 1;
        }else{
            image3.transform.position = imageInicioPos3;
        }
    }

    public void DropImage4(){
        float Distance = Vector3.Distance(image4.transform.position, flagBrasil.transform.position);
        if (Distance < 100){
            image4.transform.position = flagBrasil.transform.position;
            audioSound.clip = soundCooking[3];
            audioSound.Play();
            contadorBrasil += 1;
        }else{
            image4.transform.position = imageInicioPos4;
        }
    }

    public void DropImage5(){
        float Distance = Vector3.Distance(image5.transform.position, flagBrasil.transform.position);
        if (Distance < 100){
            image5.transform.position = flagBrasil.transform.position;
            audioSound.clip = soundCooking[4];
            audioSound.Play();
            contadorBrasil += 1;
        }else{
            image5.transform.position = imageInicioPos5;
        }
    }

    public void DropImage6(){
        float Distance = Vector3.Distance(image6.transform.position, flagBrasil.transform.position);
        if (Distance < 100){
            image6.transform.position = flagBrasil.transform.position;
            audioSound.clip = soundCooking[5];
            audioSound.Play();
            contadorBrasil += 1;
        }else{
            image6.transform.position = imageInicioPos6;
        }
    }

    public void DropImage7(){
        float Distance = Vector3.Distance(image7.transform.position, flagBrasil.transform.position);
        if (Distance < 100){
            image7.transform.position = flagBrasil.transform.position;
            audioSound.clip = soundCooking[6];
            audioSound.Play();
            contadorBrasil += 1;
        }else{
            image7.transform.position = imageInicioPos7;
        }
    }

    public void DropImage8(){
        float Distance = Vector3.Distance(image8.transform.position, flagMocambique.transform.position);
        if (Distance < 100){
            image8.transform.position = flagMocambique.transform.position;
            audioSound.clip = soundCooking[7];
            audioSound.Play();
            contadorMocambique += 1;
        }else{
            image8.transform.position = imageInicioPos8;
        }
    }

    public void DropImage9(){
        float Distance = Vector3.Distance(image9.transform.position, flagMocambique.transform.position);
        if (Distance < 100){
            image9.transform.position = flagMocambique.transform.position;
            audioSound.clip = soundCooking[8];
            audioSound.Play();
            contadorMocambique += 1;
        }else{
            image9.transform.position = imageInicioPos9;
        }
    }

    void Update(){
        contadorAngolaText.text = "Angola: "+ contadorAngola.ToString();
        Debug.Log(contadorAngola);

        contadorBrasilText.text = "Brasil: "+ contadorBrasil.ToString();
        Debug.Log(contadorBrasil);

        contadorMocambiqueText.text = "Moçambique: "+ contadorMocambique.ToString();
        Debug.Log(contadorMocambique);

        if(contadorAngola == 2){
            image1.GetComponent<Image>().enabled = false;
            image2.GetComponent<Image>().enabled = false;
        }

        if(contadorBrasil == 5){
            image3.GetComponent<Image>().enabled = false;
            image4.GetComponent<Image>().enabled = false;
            image5.GetComponent<Image>().enabled = false;
            image6.GetComponent<Image>().enabled = false;
            image7.GetComponent<Image>().enabled = false;
        }

        if(contadorMocambique == 2){
            image8.GetComponent<Image>().enabled = false;
            image9.GetComponent<Image>().enabled = false;
        }

        if(contadorAngola == 2 && contadorBrasil == 5 && contadorMocambique == 2){
            timer += Time.deltaTime;
            seconds = (int)(timer % 10);

            if (seconds == 5){
                SceneManager.LoadScene("HappyBirthday");
            }
        }
    }
}
