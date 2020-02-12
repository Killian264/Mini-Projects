// All rights reserved (c) 2020 P. Tim Miller
// For academic use only
//package edu.dsu.CIS340;
package com.company;
import org.omg.CORBA.TIMEOUT;

import java.util.Iterator;
import java.util.concurrent.TimeUnit;
import java.util.stream.IntStream;

import java.util.Arrays;
import java.util.List;

/*  STUDENT SUBMISSION HERE
*  Modify each function below to find the max integer.
*  Submit only this source code to D2L for credit
*  <student name>
*/
public class StudentLoops implements Loops {
    // this is only used to store max for each function and is cleared before use.
    // There's probably a good reason for lambda's not to like non final variables but I don't know it
    // The thing I really don't understand is why this works
    int max = 0;

    public int getMaxMultiArray(int[][] intArray) {
        // clearing max
        max = 0;
        for (int[] array : intArray) {
            IntStream range = IntStream.rangeClosed(0, array.length - 1);
            range.forEach((x) -> max = array[x] > max ? array[x] : max);
        }

        return max;
    }

// Messing around with threads and workers


//    public int getMaxMultiArray(int[][] intArray)d{
//        int max = 0;
//        int count;
//
//        Thread[] threads = new Thread[10];
//        worker[] workers = new worker[10];
//
//
//        int range = intArray.length / 10;
//        for (count = 0; count < 10; count++) {
//            int startAt = count * range;
//            int endAt = startAt + range;
//            workers[count] = new worker(startAt, endAt, intArray);
//
//        }
//
//        for (count = 0; count < 10; count++) {
//            threads[count] = new Thread(workers[count]);
//            threads[count].start();
//        }
//
//        boolean isProcessing = false;
//        do {
//            isProcessing = false;
//            for (Thread t : threads) {
//                if (t.isAlive()) {
//                    isProcessing = true;
//                    break;
//                }
//            }
//        } while (isProcessing);
//
//        for (worker worker : workers) {
//            max = worker.getMax() > max ? worker.getMax() : max;
//        }
//        return max;
//
//    }

    public static class worker implements Runnable {

        private int startAt;
        private int endAt;
        private int intArray[][];

        int max = Integer.MIN_VALUE;

        public worker(int startAt, int endAt, int[][] intArray) {
            this.startAt = startAt;
            this.endAt = endAt;
            this.intArray = intArray;
        }

        @Override
        public void run() {
            for (int i = startAt; i < endAt; i++) {
                for(int j = 0; j < intArray[i].length; j++) {
                    max = intArray[i][j] > max ? intArray[i][j] : max;
                }
            }
        }

        public int getMax() {
            return max;
        }

    }


    public int getMaxList(List<Integer> intList){
        // clearing max
        max = 0;
//        int max = 0;
//        for(int i : intList) {
//            max = i > max ? i : max;
//        }
//        return max;
//        intList.forEach((x) -> max = x > max ? x : max);
//        return max;
//        for (Iterator<Integer> iter = intList.iterator(); iter.hasNext(); ) {
//            Integer element = iter.next();
//            max = element > max ? element : max;
//            // 1 - can call methods of element
//            // 2 - can use iter.remove() to remove the current element from the list
//
//            // ...
//        }
        //return max;
//        IntStream range = IntStream.rangeClosed(0, intList.size()-1);
//        range.forEach((x) -> max = intList.get(x) > max ? intList.get(x) : max);

        for (int i = 0; i < intList.size(); i++) {
            Integer element = intList.get(i);
            max = element > max ? element : max;
            // 1 - can call methods of element
            // 2 - can use 'i' to make index-based calls to methods of list

            // ...
        }
        return max;
//        max = 0;
//        Object[] t = intList.toArray();
//        IntStream range = IntStream.rangeClosed(0, t.length-1);
//        range.forEach((x) -> max = (int)t[x] > max ? (int)t[x] : max);
//        for(int i = 0; i < intList.size(); i++){
//            IntStream range = IntStream.rangeClosed(0, array.length-1);
//            range.forEach((x) -> max = array[x] > max ? array[x] : max);
//        }
        //while(intList.iter)
//        object[] array = intList.toArray();
//        IntStream range = IntStream.rangeClosed(0, array.length-1);
//        range.forEach((x) -> max = array[x] > max ? array[x] : max);
//        int curr1;
//        int curr2;
//        for(int i = 0; i < intList.size()/2; i++) {
//            max = i > max ? i : max;
//        }
        //return max;
    }

    public int getMaxArrayList(List<int[]> intArrayList){
        // clearing max
        max = 0;

        for(int[] array: intArrayList){
            IntStream range = IntStream.rangeClosed(0, array.length-1);
            range.forEach((x) -> max = array[x] > max ? array[x] : max);
        }

        return max;
    }
}
