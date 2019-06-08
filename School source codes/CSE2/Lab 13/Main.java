import java.util.Random;
import java.util.concurrent.atomic.AtomicInteger;

class MultiThreading extends Thread {
  public void run(int[] a, int l, int k) { 
    try{ 
      System.out.println("Thread " + Thread.currentThread().getId() + " is running");
      for(int i = l; i < k; i++){
        Main.increment(a[i]);
      }
    }catch (Exception e) { 
      System.out.println ("Exception is caught"); 
    } 
  } 
}

class Main {
  private static AtomicInteger sum = new AtomicInteger(0);
  public static void increment(int a){
    sum.incrementAndGet();
    sum.addAndGet(a);
  }
  public static void main(String[] args) {
    Random rand = new Random();
    int[] testing = new int[100000];
    for(int i = 0; i < 100000; i++){
      testing[i] = rand.nextInt(10);
    }
    System.out.println(sum);
    MultiThreading m = new MultiThreading();
    MultiThreading n = new MultiThreading();
    MultiThreading b = new MultiThreading();
    MultiThreading v = new MultiThreading();
    MultiThreading l = new MultiThreading();
    MultiThreading c = new MultiThreading();
    MultiThreading x = new MultiThreading();
    MultiThreading a = new MultiThreading();
    MultiThreading s = new MultiThreading();
    MultiThreading z = new MultiThreading();
    m.run(testing, 0, 10000);
    n.run(testing, 10000, 20000);
    b.run(testing, 20000, 30000);
    v.run(testing, 30000, 40000);
    c.run(testing, 40000, 50000);
    x.run(testing, 50000, 60000);
    a.run(testing, 60000, 70000);
    s.run(testing, 70000, 80000);
    z.run(testing, 80000, 90000);
    l.run(testing, 90000, 100000);
    System.out.println(sum);
  }
}