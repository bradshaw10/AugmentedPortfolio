using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OnTargetFound : MonoBehaviour
{
    public Text textBox;
    public GameObject InfoImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnITBFound(){
        if(this.InfoImage.active)
        {
            this.InfoImage.SetActive(false);
        }

        this.InfoImage.SetActive(true);
        this.textBox.text = "Following a year out of education, I accepted a place in Computer Science in ITB. I spent 4 years studying a variety of different modules. Among those my particular favourite was mobile application development. Following my graduation I attended Queens University where I received a post graduate diploma in Business and Project Management";
    }

    public void OnCAFCFound(){
        if (this.InfoImage.active)
        {
            this.InfoImage.SetActive(false);
        }

        this.InfoImage.SetActive(true);
        this.textBox.text = "I have played football since I learned to walk, it has always been one of my passions. In 2014 I helped found a new club in Dublin 15, Carpenterstown FC. Along with a group of my friends, we have run the club since. Our proudest moment was winning the league shield in our first year as a club.";
    }

    public void OnSatoriFound()
    {
        if (this.InfoImage.active)
        {
            this.InfoImage.SetActive(false);
        }


        this.InfoImage.SetActive(true);
        this.textBox.text = "Sports have always been close to my heart, as well as football a sport a sport I excelled at was MMA. I began training in 2010 at the age of 16 and by the age of 19 I was an Irish amateur champion. Since then I have competed many times on received coaching qualifications under John Kavanagh";
    }

    public void OnRetailIntFound()
    {
        if (this.InfoImage.active)
        {
            this.InfoImage.SetActive(false);
        }

        this.InfoImage.SetActive(true);
        this.textBox.text = "I began working in Retail Integration in 2018. I was hired to develop some upcoming mobile projects. Origially the applications were developed in unity, but as demand increased we oversaw a move to the Xamarin framework";
    }

    public void OnNavigateAway()
    {
        this.InfoImage.SetActive(false);
        this.textBox.text = "";
    }
}
