/* Example Code for Game Programming Design Patterns
 * Author: Owen Schaffer
 * with code adapted from GameDevHQ
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Delegates
{
    public class GameManager : MonoBehaviour
    {
        //delegates hold methods
        //this is how we declare them
        public delegate void ChangeColor(Color newColor);
        public ChangeColor onColorChange;

        public delegate void OnComplete();
        public OnComplete onComplete;
        

        // Start is called before the first frame update
        void Start()
        {
            //The signature of the delegate must match the method being assigned to it
            //So, this line will not work:
            //onColorChange = Task;
            
            //Assigning methods to delegates
            onColorChange = UpdateColor;
            onComplete = Task1;

            onColorChange(Color.green);
            onComplete();

            onComplete += Task2;
            onComplete += Task3;

            onComplete -= Task2;

            /*Since we are adding and removing objects,
             * it is a good idea to make sure onComplete is not null
             * before we call the method the delegate is holding.
             */
            if (onComplete != null)
            {
                onComplete();
            }
        }

        public void UpdateColor(Color newColor)
        {
            Debug.Log("Changing color to: " + newColor.ToString());
        }

        public void Task1()
        {
            Debug.Log("Task 1 Finished");
        }

        public void Task2()
        {
            Debug.Log("Task 2 Finished");
        }

        public void Task3()
        {
            Debug.Log("Task 3 Finished");
        }

        // Update is called once per frame
        void Update()
        {

        }


    }

}