using System;
using Cs_code;
using UnityEngine;

namespace Person_manager
{
    public class Person_manager : MonoBehaviour
    {
        public Person person; 
        
        public string name;
        public int age;
        public void Start()
        {
            
            
        }
        
        
        public void Intruction()
        {
            Debug.Log(message:$"Hello my name is {name}, i am {age} years old");

        }

        
    }
}