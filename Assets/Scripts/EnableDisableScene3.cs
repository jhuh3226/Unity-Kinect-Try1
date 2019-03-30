﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableScene3 : MonoBehaviour {
    //game object turn on and off
    public GameObject directionalLight;
    public GameObject pointLight1;
    public GameObject pointLight2;
    //public GameObject pointLightLamp;
    public GameObject middleAgedSitting;

    //isKinemetic turn on and off
    //public GameObject book;

    public GameObject gameObContainingScript;
    public GameObject gameObContainingRenderLightScript;

    void Update()
    {
        RenderLight RenderLightScript = gameObContainingRenderLightScript.GetComponent<RenderLight>();
        EnableDisableSceneOverall EnableDisableSceneOverallScript = gameObContainingScript.GetComponent<EnableDisableSceneOverall>();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (EnableDisableSceneOverallScript.scene3On == true)
            {
                //RenderLightScript.renderIntensity = 1;
            }
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
           // RenderLightScript.renderIntensity = 0;
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (EnableDisableSceneOverallScript.scene3On == true)
            {
                //RenderLightScript.renderIntensity = 1;

                //camera
                //GameObject.Find("Main Camera2").transform.position = new Vector3(0, 1.3f, -0.72f);

                directionalLight.SetActive(false);
                pointLight1.SetActive(false);
                pointLight2.SetActive(true);
                //pointLightLamp.SetActive(true);
                //middleAgedSitting.SetActive(true);

                //destory
                Destroy(GameObject.FindWithTag("girlMiddleAgedHappy"));

                //isKinemetic
                //Rigidbody frameRigidbody = book.GetComponent<Rigidbody>();
                //frameRigidbody.isKinematic = false;
            }
        }
    }
}