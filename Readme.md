
# Dilangram

## About
Dilangram is a powerful Telegram message management tool developed in 2021 using WTelegram. Previously a commercial product, it is now freely available as open-source software for the community.

## Features
- **Easy Authentication**: Securely log into your Telegram account
- **Fast Message Management**: 
  - Quick copy messages between chats
  - Move messages between groups and channels
  - Bulk message operations
- **Channel Management**:
  - Manage multiple channels from one interface
  - Easy content distribution across channels
  - Streamlined message forwarding

## How It Works

### Authentication
1. Configure your Telegram API credentials in `Program.cs`:
   ```csharp
   internal static int api_id = 0000000;
   internal static string api_hash = "00000000000000000000000000000";
   ```
   You can obtain these credentials from https://my.telegram.org

2. Run the application and log in with your Telegram account

### Main Features
1. **Chat Selection**
   - Use the Chat Selector dialog to choose source and destination chats
   - Supports both private chats and channels
   - Recent chats are easily accessible

2. **Message Operations**
   - Select messages from the source chat
   - Choose to copy or move messages
   - Select destination channel/group
   - Execute the operation with a single click

3. **Content Channel Management**
   - Create and manage content distribution channels
   - Set up automated message forwarding rules
   - Monitor channel activity

4. **Job Editor**
   - Create automated tasks for message management
   - Schedule message operations
   - Set up recurring tasks

## Project Structure
- `Dialog/`: Contains UI dialogs for user interaction
- `Forms/`: Main application forms including:
  - `frmContentChannel.cs`: Channel management interface
  - `frmJobEditor.cs`: Task automation interface
  - `frmSendMessages.cs`: Message sending interface
- `Helpers/`: Utility and helper classes
- `Models/`: Data models and business logic
- `Enums/`: Enumeration definitions

## Building from Source

### Prerequisites
- Visual Studio 2019 or later
- .NET Framework 4.7.2 or later
- WTelegramClient NuGet package

### Setup
1. Clone the repository:
   ```powershell
   git clone https://github.com/FouadAbdi/Dilangram.git
   ```

2. Open `Dilangram.sln` in Visual Studio

3. Restore NuGet packages

4. Build the solution

### Cleaning Build Artifacts
To remove build artifacts, run in PowerShell:
```powershell
Remove-Item -Recurse -Force .\obj
Remove-Item -Recurse -Force .\bin
```

## License
This project is now open source and free to use. Previously a commercial product, it has been made freely available to benefit the developer community.

## Contributing
Contributions are welcome! Feel free to:
- Report bugs
- Suggest new features
- Submit pull requests
- Fork the project and add new features

## Support & Development
For support or inquiries, contact: fouad.abdi78@gmail.com

### Note from the Author
While I remain interested in enhancing Dilangram and redesigning its UI, my time for development is currently limited. I encourage the community to:
- Fork the project and add new features
- Contribute to UI improvements or Other Feautures ...
- Share your ideas and suggestions
- Get in touch if you'd like to become a contributor

If you're interested in taking the project further, please don't hesitate to contact me or fork the repository. Your contributions can help make Dilangram even better!

## Repository
[GitHub - FouadAbdi/Dilangram](https://github.com/FouadAbdi/Dilangram)

## History
- 2021: Initial development and commercial release
- 2025: Transitioned to open-source model