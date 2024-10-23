package com.example.a1labn;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void onButtonClick(View v){
        // ПЕРЕХОД МЕЖДУ СТРАНИЦАМИ  С ПОМОЩЬЮ Intent
        Intent intent = new Intent(MainActivity.this, MainActivity2.class);
        // Передаем параметр с фамилией
        intent.putExtra("surname", "Петухов");
        startActivity(intent); // Запускаем SecondActivity
    }
}