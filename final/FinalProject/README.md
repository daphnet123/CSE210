ADHD To-Do List App

Overview:
The ADHD To-Do List App is designed to help people with ADHD manage tasks in a way that works for their unique needs. Traditional to-do lists often fall short for people with ADHD due to the interest-based nature of their nervous system. This app is built to encourage task completion by incorporating gamification, customizable alerts, and a points system to make task management engaging and rewarding.

Problem:
For individuals with ADHD, completing tasks that lack inherent interest can feel nearly impossible, even when those tasks are urgent or necessary. For example, someone with ADHD might find themselves scrolling on their phone, fully aware that they need to complete a chore but unable to start. This app aims to bridge the gap between awareness and action by leveraging the motivation systems that work for people with ADHD.

Solution:
The app focuses on creating an interactive, customizable, and rewarding experience for task management. Here are its core features:
1. Gamified Task Completion:
- Earn 100 points per completed room (cleaning, organizing, whatever task that needs completing in that room).
- Earn 50 points for attempting tasks after alerted for cleaning "event" (even if task is incomplete, the user has at least tried to make a change in that room).
- Earn 10 points for completing individual tasks outside of "event" alerts.
- Accumulate 1000 points to earn a badge.
2. Customizable Alerts:
- Set reminders for tasks with a variety of options (30 minutes, 15 minutes, 10 minutes, and 5 minutes) before an "event".
- Customize the type, timing, and sound preferences for alerts.
3. Event Creation:
- Organize tasks around event names like "Gaming Hangout," "Friendsgiving," or "Christmas Party."
- Group Tasks by room and set durations for task completion. (Gaming Hangout could align with cleaning the living room or other tasks in the living room. It is all customizable for the user).
4. Progress Tracking:
- Monitor progress using a tracker displaying total points and progress toward the next badge.
- Receive feedback and encouragement after each event or task attempt.

How It Works:
1. Setup:
- Users create a list of rooms and tasks within their home.
- Tasks can be grouped into "events" for specific occasions.
2. Event Planning:
- Set event names, dates, times, and durations.
- Adjust alerts for when reminders will trigger.
3. Task Completion:
- As tasks are completed, users earn points based on effort and success.
- Attempting a task during an alert earns partial points.
4. Rewards System:
- Points are added to a progress bar.
- Every 1000 points earns a badge, motivating consistent progress.

Example Flow:
1. Plan an Event - Create an event called "Friendsgiving", select rooms that you need to complete tasks in (sweeping, mopping, picking up, full clean, deep clean, etc.), and set a reminder for when you want to complete this task by.
2. Receive Alerts - Get reminders 30, 15, and/or 10 minutes before the "event".
3. Complete Tasks - Clean the room(s) that are connected to the "Friendsgiving" event. Earn 100 points per room. Making an attempt or partially completing a task will earn you partial points.
4. Track Progress - Watch your points grow on the progress tracker. Earn badges for reaching milestones!

How to Run the Program:
1. Clone the repository via GitHub from the final folder. - git clone https://github.com/daphnet123/CSE210.git
2. Open the project in Visual Studio.
3. Build and run the program. The main entry point is Program.cs.

Project Features:
Classes:
- User: Tracks user progress, points, and badges.
- Task: Represents individual tasks with completion and attempt status.
- Room: Groups tasks by location.
- Event: Organizes tasks and manages reminders.
- Alert: Handles customizable reminders.
- PointsSystem: Tracks and calculates points for rewards.
Key Methods:
- AddPoints(int points): Updates user points.
- MarkComplete(): Marks a task as completed.
- TriggerAlert(): Displays a reminder message.
- CalculatePoints(): Calculates points for completed tasks during an event.

Author:
Daphne Tryk
This app is a personal project inspired by the challenges of ADHD and the need for a more dynamic, interest-driven approach to task management. As someone who has ADHD and doesn't have access to the medication that could help me, I really struggle sometimes to complete tasks and have to use all sorts of variations of interest-based stimulations for my brain to actually allow me to complete tasks. If I had known how important an interest-based nervous system becoming stimulated through tricking it into completing tasks, I would have been much more successful in my education when I was younger. I hope that this is something that could be turned into a real app one day that could help all sorts of people with ADHD to not feel guilty, and actually get excited to complete tasks that are necessary in life.


