public class TestThread implements Runnable {
    @Override
    public void run() {
        try {
            Thread.sleep((int)(Math.random() * ((2000 - 1000) + 1)));
            System.out.println(Thread.currentThread().getName() + " ha finalizado normalmente");
        } catch (InterruptedException e) {
            System.out.println(Thread.currentThread().getName() + " ha finalizado pro una interrupcion");
        }
    }
}
