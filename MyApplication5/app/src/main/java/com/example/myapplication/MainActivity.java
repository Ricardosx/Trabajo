package com.example.myapplication;

import androidx.annotation.RequiresApi;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;

import android.Manifest;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.net.Uri;
import android.os.Build;
import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @RequiresApi(api = Build.VERSION_CODES.M)
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Mensaje msj = new Mensaje();

        requestPermissions(new String[]{Manifest.permission.CALL_PHONE},111);

        Toast.makeText(this, "Hola", Toast.LENGTH_SHORT).show();
        msj.Msj(this,"Bienvenidos");
    }

    public void Contactos(View view){
        Intent intent = new Intent(Intent.ACTION_VIEW, Uri.parse("content://contacts/people"));
        startActivity(intent);
    }

    public void url (View view){
        Intent intent = new Intent(Intent.ACTION_VIEW, Uri.parse("http://google.com"));
        startActivity(intent);
    }

    public void Vista(View view){
        Intent intent = new Intent(this, SegundaVista.class);
        startActivity(intent);
    }

    public void Llamada(View view){
        Intent intent = new Intent(Intent.ACTION_CALL, Uri.parse("tel:5548116371"));
        if (ActivityCompat.checkSelfPermission(MainActivity.this, Manifest.permission.CALL_PHONE) != PackageManager.PERMISSION_GRANTED)
            return;
        startActivity(intent);
    }


}
