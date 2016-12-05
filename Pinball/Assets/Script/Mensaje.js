#pragma strict

function Start () {

}

var mensaje : String; // mensaje q se va a mostrar 
var entro : boolean = false;




function Update () {






}function OnGUI() {


    if(entro){


        GUI.Label(Rect((Screen.width/2)-40,(Screen.height/2)-100,200,30),mensaje);
    
    }




}function OnTriggerEnter() {


    entro = true;


}function OnTriggerExit() {


    entro = false;


}
