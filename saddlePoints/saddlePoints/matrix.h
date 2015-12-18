#pragma once

struct Matrix;

Matrix* createMatrix(int matrixWidth, int matrixHeight);//create matrix

void setNumber(Matrix* matrix, int stringNumber, int columnNumber, int number);//set number in matrix

int getNumber(Matrix* matrix, int stringNumber, int columnNumber);//get number from matrix

int getWidthNumber(Matrix* matrix);//get matrix width

int getHeightNumber(Matrix* matrix);//get matrix height

void deleteMatrix(Matrix* matrix);//delete all matrix