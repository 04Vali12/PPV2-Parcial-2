using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Leccion
{
  public int ID;
  public string lessons;
  public List<string> options;
    public int CorrectAnswer;  
 }
[CreateAssetMenu(fileName = "New subject", menuName = "ScriptableObjects/newLesson", order =1)]

public class Subject : ScriptableObject
{
    [Header("GameObject Configuracion")]
    public int Lesson = 0;
    [Header("Leccion Quest Configuracion")]
    public List<Leccion> leccionList;

}
