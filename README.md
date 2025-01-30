<div align="center">

  # 🎥 OBSTimer ⏱️
  
  ![GitHub Release](https://img.shields.io/github/v/release/NATroutter/OBSTimer?style=for-the-badge)
  ![Platform](https://img.shields.io/badge/platform-Windows-brightgreen.svg?style=for-the-badge)
  ![License](https://img.shields.io/badge/license-MIT-yellow.svg?style=for-the-badge)
  ![Made with ❤️](https://img.shields.io/badge/made%20with-%E2%9D%A4-red.svg?style=for-the-badge)
  
</div>
**OBSTimer** is a simple yet powerful tool designed to enhance your **OBS (Open Broadcaster Software)** experience by providing real-time timer functionality. The software automatically starts a timer as soon as it launches, requiring no manual input or event triggers. It works by:

- **Creating a "started.txt" file** that records the exact moment the timer begins.
- **Updating a "current.txt" file every second**, showing the elapsed time since the timer started.

These text files can be easily integrated into OBS, allowing you to dynamically display the timer's start time and runtime during your streams or recordings. With its **automatic operation and straightforward design**, OBSTimer is perfect for streamers and content creators looking for a hassle-free way to add real-time timer information to their broadcasts.

## 🚀 Take It to the Next Level with a Stream Deck

You can make OBSTimer even more versatile by pairing it with a **Stream Deck**. Using the **multi-action feature**, you can automate multiple tasks with a single button press. For example:

- **Start the OBSTimer** to begin tracking elapsed time.
- **Switch to your BRB (Be Right Back) scene** in OBS.

This setup allows you to seamlessly transition to a BRB screen while simultaneously starting a timer to track how long you've been away. With the Stream Deck's ability to execute actions in sequence or simultaneously, you can create a smooth and professional workflow for your streams. Whether you're stepping away for a break or managing complex live events, OBSTimer and a Stream Deck together can streamline your production and elevate your content quality.

## 🛠️ Using the Application

There are multiple ways to start and use the **OBSTimer** application, making it flexible and easy to integrate into your workflow:

1. **Interactive Mode**  
   Simply run the application, and it will prompt you to enter the name of the timer you want to use. This is a straightforward option for users who prefer a manual setup.

2. **Command-Line Mode**  
   Launch the application from the command line with arguments. If you provide a single argument, it will be used as the name of the timer.  
   For example: 

   ```
   OBSTimer.exe BreakTimer
   ```
This method is particularly useful for automation and integration with tools like **Stream Deck** or other applications. By configuring a Stream Deck button to execute this command, you can start specific timers with a single press, streamlining your workflow.
