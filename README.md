<h1 align="center">Retrieve-Mail</h1>
<p align="center">Retrieve mail and download content/attachment in folder</p>
<p align="center">
  <img src="https://img.shields.io/maintenance/yes/2023?style=for-the-badge" alt="Maintained">
  <a href="https://github.com/hsangrento/retrieve-mail/blob/dev/LICENSE"><img src="https://img.shields.io/github/license/hsangrento/retrieve-mail?sanitize=true&style=for-the-badge" alt="License"></a>
</p>

---

# Project Setup
⚠️ This project only it only works on MacOS, if you want it to work on Windows, you can develop the project.

If you do not have a <a href="https://learn.microsoft.com/tr-tr/dotnet/core/install/macos">dotnet</a>, you must download it.

### Install
Firstly, open your terminal and type in.

```bash
dotnet new console
```

Then open in your folder and replace Program.cs in your file with the Program.cs you downloaded.

### Requirements

Just you must install "EAGetMail" package, that's it.

```bash
dotnet add package EAGetMail
```

### Build
If you'll build this project, type it in your console.

```bash
dotnet build
```

### Configuration
For this you need to open the contents of the Program.cs file. You need to enter your e-mail in the "your email" section of the program, and your password or two-factor password in the "password" section.

# License

This project is licensed under the GNU General Public License v2.0 - see the [LICENSE](LICENSE) file for details.
