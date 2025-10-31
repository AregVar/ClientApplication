# Windows Service Manager

A lightweight and extensible Windows client application built with **C#** and **.NET**, designed to control and monitor Windows services, manage configuration options through a local SQLite database, and trigger automated REST API calls based on schedules.  
It serves as a companion tool for managing and interacting with the `RestClientService`, allowing full remote or local service control.

## Features

- **Start / Stop Service** — control your Windows service directly from the application.
- **Automated Scheduler** — periodically sends API requests to your REST service based on schedule parameters.
- **SQLite-Based Configuration** — all settings (host, schedule, etc.) are stored in an embedded `options.db` databases `OptionsTable` table.
- **Manual Options Editing** — open and modify `options.db` manually if the service becomes inaccessible.
- **Templates Management** — add, delete, view or edit the emails body from `Templates` table of `options.db`.

## Installation
### 1. Clone the repository
```bash
git clone https://github.com/<your-username>/<repository-name>.git
cd <repository-name>
```

### 2. Open the project

- Launch Visual Studio 2022 (or newer).

- Open the solution file:
  ClientApplication.sln

### 3. Restore dependencies
Visual Studio usually restores NuGet packages automatically.
If not, run manually:
```bash
dotnet restore
```
### 4. Build the project
```bash
dotnet build --configuration Release
```
### 5. Run the application

You can:

Run it directly from Visual Studio (recommended for testing).
Important: Run as Administrator.

Or launch the compiled executable from:

/bin/Release/netX.X/publish/

### Additionally
This programm requres: 

- windowsdesktop-runtime-9.0.9
- MicrosoftEdgeWebView2Runtime
- dotnet-runtime-9.0.9

## Structure
Project consists of many forms, each responsible for different tasks with service.
- **AllOptions form** — The main form, that contains all service options as tabs: Templates, SMTP Options, Service Managment, Sending Test and Schedule tabs. Some of the tabs contain forms as body. it contains 2 buttons: Service Name and Service Host, to connect to your service and to check if there is a local service on your computer.
- The tab Service Management contains 3 buttons, start-Starts local service, stop-Stops the local service, open local db-An emergancy way to open the options.db from selected place.
- Schedule tab contains 3 textboxes: Hour, Minute and Interval. It also contains a
save changes button, which saves the changes of schedule options to `Schedule` table from `options.db`.
- **SMTP Options form** — Contains a grid in which is shown `SMTPOptions` table from `options.db`. There are 2 buttons and 1 grid on the form: Edit and Refresh buttons and Options grid. by clicking Edit button a new EditOption form opens where you can edit the option's value and category. After the action you can refresh the grid if needed (after edit it does an automatic refresh).
It sends a request to the Rest Client Service and gets the options.
- **Templates Options form** — Contains a grid in which is shown `Templates` table from `options.db`. There are 5 buttons, 1 combobox and 1 grid on the form: add, edit, view, delete and refresh buttons, Templates grid and a Filter combobox.
Pressing Delete button will delete the selected template from the table, pressing Add button will opens a new window, AddTemplate form, where you can create a new template, pressing Edit button opens a new window, EditTemplate form, where you can edit the selected form
pressing View will open an EditForm in view mode (no way to change things in form) with selected template info, pressing refresh will refresh the info in grid. The Genders combobox is responsible of sorting data in Templates grid. It shows All and other genders that are in
grid. You can choose one from combobox to sort the grid by that gender.
- **Manual Send (Sending Test) form** — With this form, you can test-send an email to a test person, by filling in all the textboxes and comboboxes and pressing Send email button. There are 2 comboboxes, Gender and Template. To fill the comboboxes, press refresh button.
In this form you can also send emails with people info from Info Rest Serivece and with the options from `options.db`. The reqired fields to be filled are: receivers name, last name, email, gender and template, senders email, pwd, SMTP host and port.

More stuff later


