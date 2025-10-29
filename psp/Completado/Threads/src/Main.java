import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        System.out.println("Ingresa un número...");
        int n = new Scanner(System.in).nextInt();
        ArrayList<Thread> threads = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            Thread thread = new Thread(new TestThread());
            thread.setName("Thread " + i);
            threads.add(thread);
        }

        for (Thread thread : threads) {
            thread.start();
        }

        threads.get(0).interrupt();
        threads.get(1).interrupt();

        for (int i = 2; i < threads.size(); i++) {
            try {
                threads.get(i).join();
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }

        System.out.println("PROGRAMA FINALIZADO");

    }
}