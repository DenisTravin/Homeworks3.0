#pragma once

const int maxNum = 8;//max pow of 2 number

struct BinNumber;

BinNumber* makeBinNumber(int number);//make binary number from decimal

void printBinNum(BinNumber* binNumber);//output binary number

BinNumber* makeBinSum(BinNumber* firstBinNumber, BinNumber* secondBinNumber);//make sum from first and second binary numbers

int makeDecNumber(BinNumber* binNumber);//make decimal number from binary

void deleteBinNumber(BinNumber* binNumber);//delete binary number
