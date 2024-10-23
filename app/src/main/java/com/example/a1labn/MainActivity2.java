package com.example.a1labn;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class MainActivity2 extends AppCompatActivity{
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity2_main);

        // Получаем переданный параметр из Intent
        String surname = getIntent().getStringExtra("surname");
        // Находим TextView и устанавливаем текст с переданным параметром
        TextView TextPar = findViewById(R.id.textPar);
        TextPar.setText("Переданный параметр: " + surname);
    }
}
