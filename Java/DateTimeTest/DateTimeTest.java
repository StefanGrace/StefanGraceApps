import java.time.LocalDateTime;
class DateTimeTest {
    public static void main(String[] args) {
        LocalDateTime currentDate = LocalDateTime.now();
        System.out.println(currentDate);
        LocalDateTime latestDate = LocalDateTime.MAX;
        System.out.println(latestDate);
        LocalDateTime earliestDate = LocalDateTime.MIN;
        System.out.println(earliestDate);
        System.out.println(LocalDateTime.of(+999_999_999, 12, 31, 23, 59, 59, 999_999_999));
        System.out.println(LocalDateTime.of(-999_999_999, 01, 01, 00, 00, 00, 000_000_000));
        System.out.println(LocalDateTime.of(0000, 01, 01, 00, 00, 00, 000_000_000));
        //System.out.println(LocalDateTime.of(+1_000_000_000, 01, 01, 00, 00, 00, 000_000_000));
        //System.out.println(LocalDateTime.of(-1_000_000_000, 12, 31, 23, 59, 59, 999_999_999));
    }
}