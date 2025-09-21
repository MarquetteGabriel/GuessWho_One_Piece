/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.InterfaceManagement.GameSystem.Notifications;

import android.Manifest;
import android.app.AlarmManager;
import android.app.NotificationChannel;
import android.app.PendingIntent;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;

import androidx.core.app.ActivityCompat;
import androidx.core.app.NotificationCompat;
import androidx.core.app.NotificationManagerCompat;

import java.util.Calendar;

import fr.gmarquette.guesswho.R;

public class NotificationManager extends BroadcastReceiver {
    @Override
    public void onReceive(Context context, Intent intent) {
        NotificationCompat.Builder builder = new NotificationCompat.Builder(context, "GuessWho")
                .setSmallIcon(R.drawable.logo_guesswhoop)
                .setContentTitle("Guess Who")
                .setContentText("A data update is available")
                .setPriority(NotificationCompat.PRIORITY_DEFAULT);

        NotificationManagerCompat notificationManager = NotificationManagerCompat.from(context);

        if (ActivityCompat.checkSelfPermission(context, Manifest.permission.POST_NOTIFICATIONS) != PackageManager.PERMISSION_GRANTED) {
            return;
        }
        notificationManager.notify(200, builder.build());
    }

    public static void sendNotifications(Context context)
    {
        if (android.os.Build.VERSION.SDK_INT >= android.os.Build.VERSION_CODES.S) {
            createNotificationChannel(context);
            Intent intent = new Intent(context, NotificationManager.class);
            PendingIntent pendingIntent = PendingIntent.getBroadcast(context, 0, intent, PendingIntent.FLAG_MUTABLE);
            AlarmManager alarmManager = (AlarmManager) context.getSystemService(Context.ALARM_SERVICE);
            Calendar calendar = Calendar.getInstance();
            calendar.add(Calendar.MONTH, 1);
            calendar.set(Calendar.DAY_OF_MONTH, 1);
            long calendarTime = calendar.getTimeInMillis();
            alarmManager.set(AlarmManager.RTC_WAKEUP, calendarTime, pendingIntent);
        }
    }

    private static void createNotificationChannel(Context context)
    {
        CharSequence name = "GuessWho";
        String description = "GuessWho Notifications";
        int importance = android.app.NotificationManager.IMPORTANCE_DEFAULT;
        NotificationChannel channel = new NotificationChannel("GuessWho", name, importance);
        channel.setDescription(description);

        android.app.NotificationManager notificationManager = context.getSystemService(android.app.NotificationManager.class);
        notificationManager.createNotificationChannel(channel);
    }

    public static void cancelNotification(Context context)
    {
        Intent intent = new Intent(context, NotificationManager.class);
        PendingIntent pendingIntent = PendingIntent.getBroadcast(context, 0, intent, PendingIntent.FLAG_MUTABLE);
        AlarmManager alarmManager = (AlarmManager) context.getSystemService(Context.ALARM_SERVICE);
        alarmManager.cancel(pendingIntent);
    }
}
