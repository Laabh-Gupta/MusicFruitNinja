using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator DefaultToFreezeColor() {
        Color startColor = new Color(0.5f, 0.5f, 0.5f, 1f);
        Color endColor = new Color(0f, 0.66f, 1f, 1f);
        float tick = 0f;
        while(this.GetComponent<Renderer>().material.color != endColor) {
            tick += Time.deltaTime * 2;
            this.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, tick); 
            yield return null;
        } 
    }

    public IEnumerator DefaultToFrenzyColor() {
        Color startColor = new Color(0.5f, 0.5f, 0.5f, 1f);
        Color endColor = new Color(1f, 0.4f, 0f, 1f);
        float tick = 0f;
        while(this.GetComponent<Renderer>().material.color != endColor) {
            tick += Time.deltaTime * 2;
            this.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, tick); 
            yield return null;
        } 
    }

    public IEnumerator FrenzyToDefaultColor() {
        Color endColor = new Color(0.5f, 0.5f, 0.5f, 1f);
        Color startColor = new Color(1f, 0.4f, 0f, 1f);
        float tick = 0f;
        while(this.GetComponent<Renderer>().material.color != endColor) {
            tick += Time.deltaTime * 2;
            this.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, tick); 
            yield return null;
        } 
    }

    public IEnumerator FreezeToDefaultColor() {
        Color endColor = new Color(0.5f, 0.5f, 0.5f, 1f);
        Color startColor = new Color(0f, 0.66f, 1f, 1f);
        float tick = 0f;
        while(this.GetComponent<Renderer>().material.color != endColor) {
            tick += Time.deltaTime * 2;
            this.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, tick); 
            yield return null;
        } 
    }

    public IEnumerator FreezeToDoubleColor() {
        Color endColor = new Color(0.5f, 0f, 1f, 1f);
        Color startColor = new Color(0f, 0.66f, 1f, 1f);
        float tick = 0f;
        while(this.GetComponent<Renderer>().material.color != endColor) {
            tick += Time.deltaTime * 2;
            this.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, tick); 
            yield return null;
        } 
    } 

    public IEnumerator FrenzyToDoubleColor() {
        Color endColor = new Color(0.5f, 0f, 1f, 1f);
        Color startColor = new Color(1f, 0.4f, 0f, 1f);
        float tick = 0f;
        while(this.GetComponent<Renderer>().material.color != endColor) {
            tick += Time.deltaTime * 2;
            this.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, tick); 
            yield return null;
        } 
    } 

    public IEnumerator DoubleToFreezeColor() {
        Color startColor = new Color(0.5f, 0f, 1f, 1f);
        Color endColor = new Color(0f, 0.66f, 1f, 1f);
        float tick = 0f;
        while(this.GetComponent<Renderer>().material.color != endColor) {
            tick += Time.deltaTime * 2;
            this.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, tick); 
            yield return null;
        } 
    } 

    public IEnumerator DoubleToFrenzyColor() {
        Color startColor = new Color(0.5f, 0f, 1f, 1f);
        Color endColor = new Color(1f, 0.4f, 0f, 1f);
        float tick = 0f;
        while(this.GetComponent<Renderer>().material.color != endColor) {
            tick += Time.deltaTime * 2;
            this.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, tick); 
            yield return null;
        } 
    } 
}
