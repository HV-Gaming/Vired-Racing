using UnityEngine;
using System;
using System.Collections.Generic;

public class cc01 : MonoBehaviour
{
    public enum ControlMode
    {
        Keyboard,
        Buttons
    };

    public AudioClip[] audios;
    public AudioSource AS;

    public float speedLimit = 24.0f;

    public enum Axel
    {
        Front,
        Rear
    }

    [Serializable]
    public struct Wheel
    {
        public GameObject wheelModel;
        public WheelCollider wheelCollider;
        public GameObject wheelEffectObj;
        public ParticleSystem smokeParticle;
        public Axel axel;
    }

    public ControlMode control;

    public float maxAcceleration = 30.0f;
    public float brakeAcceleration = 50.0f;

    public float turnSensitivity = 1.0f;
    public float maxSteerAngle = 30.0f;

    public Vector3 _centerOfMass;

    public List<Wheel> wheels;

    float moveInput;
    float steerInput;

    private Rigidbody carRb;

    //private CarLights carLights;

    void Start()
    {
        carRb = GetComponent<Rigidbody>();
        //carRb.centerOfMass = _centerOfMass;

        //carLights = GetComponent<CarLights>();
    }

    public void Update()
    {
        GetInputs();
        AnimateWheels();
        WheelEffects();
        playaudio();

        // if (carRb.velocity.magnitude >= 24)
        // {
        //     carRb.velocity.magnitude = 24;
        // }

        if (carRb.velocity.magnitude >= speedLimit)
        {
            carRb.velocity = carRb.velocity.normalized * speedLimit;
        }






    }

    public void playaudio()
    {
        if (Input.GetKey(KeyCode.W))
        {
            AS.clip = audios[1];
            AS.Play();
        }
        else
        {
            AS.clip = audios[0];
            AS.Play();

        }

        if (Input.GetKey(KeyCode.Space))
        {
            AS.clip = audios[2];
            AS.Play();
            print("Braking");
        }
    }

    void LateUpdate()
    {
        Move();
        Steer();
        Brake();
        cheats();
    }

    public void MoveInput(float input)
    {
        moveInput = input;
    }

    public void SteerInput(float input)
    {
        steerInput = input;
    }

    void GetInputs()
    {
        if (control == ControlMode.Keyboard)
        {
            moveInput = Input.GetAxis("Vertical");
            steerInput = Input.GetAxis("Horizontal");
        }
    }

    void Move()
    {
        foreach (var wheel in wheels)
        {
            wheel.wheelCollider.motorTorque = moveInput * 300 * maxAcceleration * Time.deltaTime;

            if (wheel.wheelCollider.motorTorque >= 60)
            {
                wheel.wheelCollider.motorTorque = 60;
            }
        }
    }

    void Steer()
    {
        foreach (var wheel in wheels)
        {
            if (wheel.axel == Axel.Front)
            {
                var _steerAngle = steerInput * turnSensitivity * maxSteerAngle;
                wheel.wheelCollider.steerAngle = Mathf.Lerp(wheel.wheelCollider.steerAngle, _steerAngle, 0.6f);
            }
        }
    }

    void Brake()
    {
        if (Input.GetKey(KeyCode.Space) || moveInput == 0)
        {
            foreach (var wheel in wheels)
            {


                wheel.wheelCollider.brakeTorque = 300 * brakeAcceleration * Time.deltaTime;
            }


            //carLights.isBackLightOn = true;
            //carLights.OperateBackLights();
        }
        else
        {
            foreach (var wheel in wheels)
            {
                wheel.wheelCollider.brakeTorque = 0;
            }

            //carLights.isBackLightOn = false;
            //carLights.OperateBackLights();
        }

        // if (Input.GetKey(KeyCode.Space))
        // {
        //     carRb.velocity = new Vector3(0, 0, 0);

        // }
    }

    void AnimateWheels()
    {
        foreach (var wheel in wheels)
        {
            Quaternion rot;
            Vector3 pos;
            wheel.wheelCollider.GetWorldPose(out pos, out rot);
            wheel.wheelModel.transform.position = pos;
            wheel.wheelModel.transform.rotation = rot;
        }
    }

    void WheelEffects()
    {
        foreach (var wheel in wheels)
        {
            //var dirtParticleMainSettings = wheel.smokeParticle.main;

            if (Input.GetKey(KeyCode.Space) && wheel.axel == Axel.Rear && wheel.wheelCollider.isGrounded == true && carRb.velocity.magnitude >= 10.0f)
            {
                wheel.wheelEffectObj.GetComponentInChildren<TrailRenderer>().emitting = true;
                wheel.smokeParticle.Emit(1);
            }
            else
            {
                wheel.wheelEffectObj.GetComponentInChildren<TrailRenderer>().emitting = false;
            }
        }
    }

    public void cheats()
    {
        if (Input.GetKey(KeyCode.X))
        {
            print("cheats");
            this.transform.position = new Vector3(transform.position.x, 3, transform.position.z);
            this.transform.rotation = Quaternion.identity;
        }
    }




}