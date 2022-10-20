package com.example.calculator;

import androidx.appcompat.app.AppCompatActivity;

import org.mariuszgromada.math.mxparser.*;

import android.os.Bundle;
import android.text.SpannableStringBuilder;
import android.view.View;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

    EditText display;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        display = findViewById(R.id.txtValue);
        display.setShowSoftInputOnFocus(false);
    }

    private void updateText(String AddString) {
        String oldString = display.getText().toString();
        int cursorPos = display.getSelectionStart();
        String leftString = oldString.substring(0, cursorPos);
        String rightString = oldString.substring(cursorPos);

        display.setText(String.format("%s%s%s", leftString, AddString, rightString));
        display.setSelection(cursorPos + 1);
    }

    public void btnZero(View view) {
        updateText("0");
    }

    public void btnOne(View view) {
        updateText("1");
    }

    public void btnTwo(View view) {
        updateText("2");
    }

    public void btnThree(View view) {
        updateText("3");
    }

    public void btnFour(View view) {
        updateText("4");
    }

    public void btnFive(View view) {
        updateText("5");
    }

    public void btnSix(View view) {
        updateText("6");
    }

    public void btnSeven(View view) {
        updateText("7");
    }

    public void btnEight(View view) {
        updateText("8");
    }

    public void btnNine(View view) {
        updateText("9");
    }

    public void btnPoint(View view) {
        updateText(".");
    }

    public void btnPlusMinus(View view) {

    }

    public void btnAdd(View view) {
        updateText("+");
    }

    public void btnSubtract(View view) {
        updateText("-");
    }

    public void btnMultiply(View view) {
        updateText("×");
    }

    public void btnDiv(View view) {
        updateText("÷");
    }

    public void btnPercentage(View view) {
        updateText("%");
    }

    public void btnDel(View view) {
        int cursorPos = display.getSelectionStart();
        int textLength = display.getText().length();

        if (cursorPos != 0 && textLength != 0) {
            SpannableStringBuilder selection = (SpannableStringBuilder) display.getText();

            selection.replace(cursorPos - 1, cursorPos, "");
            display.setText(selection);
            display.setSelection(cursorPos - 1);
        }
    }

    public void btnClear(View view) {
        display.setText("");
    }

    public void btnEqual(View view) {
        String equation = display.getText().toString();
        equation = equation.replaceAll("÷", "/");
        equation = equation.replaceAll("×", "*");

        Expression exp = new Expression(equation);
        String result = String.valueOf(exp.calculate());

        display.setText(result);
        display.setSelection(result.length());
    }
}