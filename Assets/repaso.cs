
//Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del  total aportó cada una (indicando nombre y porcentaje) 
//y cuál es el monto del total aportado  por las tres.  
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repaso : MonoBehaviour

{
    public string nombre1;
    public string nombre2;
    public string nombre3;

    public float capitalAportado1;
    public float capitalAportado2;
    public float capitalAportado3;

    float Porcentaje1;
    float Porcentaje2;
    float Porcentaje3;
    float Total;
    // Start is called before the first frame update
    void Start()
    {
        Total = capitalAportado1 + capitalAportado2 + capitalAportado3;
        Porcentaje1 = capitalAportado1 / Total * 100;
        Porcentaje2 = capitalAportado2 / Total * 100;
        Porcentaje3 = capitalAportado3 / Total * 100;

        Debug.Log("Nombre:"+nombre1 +" capital aportado:$"+capitalAportado1 +", Porcentaje del capital: %"+Porcentaje1 +", Monto total aportado: $"+Total );
        Debug.Log("Nombre:" + nombre2 + " capital aportado:$" + capitalAportado2 + ", Porcentaje del capital: %" + Porcentaje2 + ", Monto total aportado: $" + Total);
        Debug.Log("Nombre:" + nombre3 + " capital aportado:$" + capitalAportado3 + ", Porcentaje del capital: %" + Porcentaje3 + ", Monto total aportado: $" + Total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
