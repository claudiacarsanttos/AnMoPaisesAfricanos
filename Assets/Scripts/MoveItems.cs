using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveItems : MonoBehaviour
{
    public GameObject image1, image2, image3, image4, image5, image6, image7, image8, image9, image10, 
    openChestDance, openChestArt, closedTrunkDance, closedTrunkArt;

    Vector2 imageInicioPos1, imageInicioPos2, imageInicioPos3, imageInicioPos4, imageInicioPos5, 
    imageInicioPos6, imageInicioPos7, imageInicioPos8, imageInicioPos9, imageInicioPos10;

    public AudioSource audioSound;
    public AudioClip[] soundItems;

    float timer = 0.0f;
    int seconds = 0;

    [SerializeField]
    public Text contadorDanceText, contadorArtText;
    private int contadorDance, contadorArt;

    void Start(){
        contadorDance = 0;
        contadorArt = 0;
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
        imageInicioPos10 = image10.transform.position;

        closedTrunkDance.transform.position = openChestDance.transform.position;
        closedTrunkArt.transform.position = openChestArt.transform.position;

        closedTrunkDance.GetComponent<Image>().enabled = false;
        closedTrunkArt.GetComponent<Image>().enabled = false;

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

    public void DragImage10(){
        image10.transform.position = Input.mousePosition;
    }

    // Colocar os obejtos no baús
    public void DropImage1(){
        float Distance = Vector3.Distance(image1.transform.position, openChestDance.transform.position);
        if (Distance < 50){
            image1.transform.position = openChestDance.transform.position;
            audioSound.clip = soundItems[0];
            audioSound.Play();
            contadorDance += 1;
        }else{
            image1.transform.position = imageInicioPos1;
        }
    }

    public void DropImage2(){
        float Distance = Vector3.Distance(image2.transform.position, openChestDance.transform.position);
        if (Distance < 100){
            image2.transform.position = openChestDance.transform.position;
            contadorDance += 1;
            audioSound.clip = soundItems[1];
            audioSound.Play();
        }else{
            image2.transform.position = imageInicioPos2;
        }
    }

    public void DropImage3(){
        float Distance = Vector3.Distance(image3.transform.position, openChestDance.transform.position);
        if (Distance < 100){
            image3.transform.position = openChestDance.transform.position;
            contadorDance += 1;
            audioSound.clip = soundItems[2];
            audioSound.Play();
        }else{
            image3.transform.position = imageInicioPos3;
        }
    }

    public void DropImage4(){
        float Distance = Vector3.Distance(image4.transform.position, openChestDance.transform.position);
        if (Distance < 100){
            image4.transform.position = openChestDance.transform.position;
            audioSound.clip = soundItems[3];
            audioSound.Play();
            contadorDance += 1;
        }else{
            image4.transform.position = imageInicioPos4;
        }
    }

    public void DropImage5(){
        float Distance = Vector3.Distance(image5.transform.position, openChestDance.transform.position);
        if (Distance < 100){
            image5.transform.position = openChestDance.transform.position;
            audioSound.clip = soundItems[4];
            audioSound.Play();
            contadorDance += 1;
        }else{
            image5.transform.position = imageInicioPos5;
        }
    }

    public void DropImage6(){
        float Distance = Vector3.Distance(image6.transform.position, openChestArt.transform.position);
        if (Distance < 100){
            image6.transform.position = openChestArt.transform.position;
            audioSound.clip = soundItems[5];
            audioSound.Play();
            contadorArt += 1;
        }else{
            image6.transform.position = imageInicioPos6;
        }
    }

    public void DropImage7(){
        float Distance = Vector3.Distance(image7.transform.position, openChestArt.transform.position);
        if (Distance < 100){
            image7.transform.position = openChestArt.transform.position;
            audioSound.clip = soundItems[6];
            audioSound.Play();
            contadorArt += 1;
        }else{
            image7.transform.position = imageInicioPos7;
        }
    }

    public void DropImage8(){
        float Distance = Vector3.Distance(image8.transform.position, openChestArt.transform.position);
        if (Distance < 100){
            image8.transform.position = openChestArt.transform.position;
            audioSound.clip = soundItems[7];
            audioSound.Play();
            contadorArt += 1;
        }else{
            image8.transform.position = imageInicioPos8;
        }
    }

    public void DropImage9(){
        float Distance = Vector3.Distance(image9.transform.position, openChestArt.transform.position);
        if (Distance < 100){
            image9.transform.position = openChestArt.transform.position;
            audioSound.clip = soundItems[8];
            audioSound.Play();
            contadorArt += 1;
        }else{
            image9.transform.position = imageInicioPos9;
        }
    }

    public void DropImage10(){
        float Distance = Vector3.Distance(image10.transform.position, openChestArt.transform.position);
        if (Distance < 100){
            image10.transform.position = openChestArt.transform.position;
            audioSound.clip = soundItems[9];
            audioSound.Play();
            contadorArt += 1;
        }else{
            image10.transform.position = imageInicioPos10;
        }
    }
    
    void Update(){
        contadorDanceText.text = "Objetos: "+ contadorDance.ToString();
        Debug.Log(contadorDance);

        contadorArtText.text = "Objetos: "+ contadorArt.ToString();
        Debug.Log(contadorArt);

        if(contadorDance == 5){
            image1.GetComponent<Image>().enabled = false;
            image2.GetComponent<Image>().enabled = false;
            image3.GetComponent<Image>().enabled = false;
            image4.GetComponent<Image>().enabled = false;
            image5.GetComponent<Image>().enabled = false;
            openChestDance.GetComponent<Image>().enabled = false;
            closedTrunkDance.GetComponent<Image>().enabled = true;
        }

        if(contadorArt == 5){
            image6.GetComponent<Image>().enabled = false;
            image7.GetComponent<Image>().enabled = false;
            image8.GetComponent<Image>().enabled = false;
            image9.GetComponent<Image>().enabled = false;
            image10.GetComponent<Image>().enabled = false;
            openChestArt.GetComponent<Image>().enabled = false;
            closedTrunkArt.GetComponent<Image>().enabled = true;
        }

        if(contadorDance == 5 && contadorArt == 5){
            timer += Time.deltaTime;
            seconds = (int)(timer % 10);

            if (seconds == 5){
                SceneManager.LoadScene("HappyBirthday");
            }
        }
    }
}
