package com.example.myapplication;

import android.content.Context;
import android.widget.Toast;

public class Mensaje {

    public void Msj(Context cont, String m){
        Toast.makeText(cont,m,Toast.LENGTH_LONG).show();
    }
}
