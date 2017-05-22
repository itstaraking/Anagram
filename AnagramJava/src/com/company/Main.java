package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        // create new scanner for input
        Scanner keyboard = new Scanner(System.in);

	    // get first string from user
        System.out.println("Enter the first word: ");
        String one = keyboard.nextLine();

        // get the second string from user
        System.out.println("Enter the second word: ");
        String two = keyboard.nextLine();

        // convert inputs to arrays
        char[] newOne = one.toLowerCase().toCharArray();
        char[] newTwo = two.toLowerCase().toCharArray();

        // sort the char arrays
        Arrays.sort(newOne);
        Arrays.sort(newTwo);

        // create new string objects from sorted arrays
        String newInput1 = new String(newOne);
        String newInput2 = new String(newTwo);

        // compare the two strings;
        if(newInput1.equals(newInput2))
        {
            System.out.println("The words are anagrams!");
        }
        else
        {
            System.out.println("The words are not anagrams!");

        }
    }
}
