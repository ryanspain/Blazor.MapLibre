<a id="readme-top"></a>

<!-- PROJECT SHIELDS -->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![License][license-shield]][license-url]
[![Issues][issues-shield]][issues-url]
[![NuGet][nuget-shield]][nuget-url]

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a>
    <img src="https://maplibre.org/_astro/maplibre-logo.wyLiUNdu_Zcg5mX.svg" alt="Logo" width="300" height="100">
  </a>

<h3 align="center">Blazor.MapLibre</h3>

  <p align="center">
    A C# wrapper around the MapLibre GL JS library
    <br />
    <br />
    <a href="https://yet-another-solution.github.io/Blazor.MapLibre/">View Demo</a>
    ·
    <a href="https://github.com/Yet-another-solution/Blazor.MapLibre/issues/new?labels=bug&template=bug-report---.md">Report Bug</a>
    ·
    <a href="https://github.com/Yet-another-solution/Blazor.MapLibre/issues/new?labels=enhancement&template=feature-request---.md">Request Feature</a>
  </p>
</div>

---

## Table of Contents

- [About the Project](#about-the-project)
- [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Installation](#installation)
- [Usage](#usage)
- [Roadmap](#roadmap)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgments](#acknowledgments)

---

## About the Project

This project is designed to make it easier for developers working on Blazor projects to integrate and use maps in their applications.

Key features include:

- Simple Blazor components to display maps powered by MapLibre GL JS.
- Support for dynamically customizable map options.
- Event handling support with detailed customization capabilities.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

---

## Getting Started

### Prerequisites

This project is built using **.NET 8**, so you need .NET 8 or a newer version installed on your system to run it.

### Installation

To install this package using NuGet, use the following command:

```bash
dotnet add package Community.Blazor.MapLibre
```

<p align="right">(<a href="#readme-top">back to top</a>)</p>

---

## Usage

After installing the package, you can start using it in your Blazor components with the following example:

### Basic Example:

```razor
<Map />
```

### Customization:

You can provide additional options for the map using the `MapOptions` property:

```razor
<Map Options="_mapOptions" />

@code {
    private readonly MapOptions _mapOptions = new MapOptions {
        // Custom map configuration here
    };
}
```

For documentation and advanced examples, refer to the [project demo site](https://yet-another-solution.github.io/Blazor.MapLibre/).

<p align="right">(<a href="#readme-top">back to top</a>)</p>

---

Skibidi mbadada
## Roadmap

This project aims to provide comprehensive mapping features using MapLibre in Blazor projects. Below is the current roadmap:

| Feature          | Status       |
|------------------|--------------|
| **Map**          | **✅ Complete** |
| - Options        | **✅ Complete** |
| **Events**       |              |
| - Event Handlers | **☑️ Partial** |
| **Methods**      | **✅ Complete** |
| - addControl()   | **✅ Complete** |
| - addImage()     | **✅ Complete** |
| - addLayer()     | **✅ Complete** |
| - addSource()    | **✅ Complete** |
| - addSprite()    | **✅ Complete** |

### Legend:

- **✅ Completed**
- **☑️ Partially implemented**
- **❌ Not started**

See the [open issues](https://github.com/Yet-another-solution/Blazor.MapLibre/issues) for a full list of proposed features and known issues.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

---

## Contributing

Contributions help make open source better for everyone! If you'd like to contribute to this project:

1. Fork the Repository.
2. Create a New Feature Branch:
    ```bash
    git checkout -b feature/AmazingFeature
    ```
3. Commit Your Changes:
    ```bash
    git commit -m 'Add an AmazingFeature'
    ```
4. Push it to Your Repository:
    ```bash
    git push origin feature/AmazingFeature
    ```
5. Open a Pull Request in the main repository.

Don't forget to ⭐ the project if you find it helpful!

---

### Top Contributors

[![Top Contrubutors](https://contrib.rocks/image?repo=Yet-another-solution/Blazor.MapLibre)](https://github.com/Yet-another-solution/Blazor.MapLibre/graphs/contributors)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

---

## License

This project is distributed under the **Unlicense License**. For more details, see `UNLICENSE`.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

---

## Acknowledgments

This project uses the following resources and tools:

- [GitHub Emoji Cheat Sheet](https://www.webpagefx.com/tools/emoji-cheat-sheet)
- [Img Shields](https://shields.io)
- [GitHub Pages](https://pages.github.com)
- [Best-README-Template](https://github.com/othneildrew/Best-README-Template)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

---

<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/Yet-another-solution/Blazor.MapLibre.svg?style=for-the-badge
[contributors-url]: https://github.com/Yet-another-solution/Blazor.MapLibre/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Yet-another-solution/Blazor.MapLibre.svg?style=for-the-badge
[forks-url]: https://github.com/Yet-another-solution/Blazor.MapLibre/network/members
[stars-shield]: https://img.shields.io/github/stars/Yet-another-solution/Blazor.MapLibre.svg?style=for-the-badge
[stars-url]: https://github.com/Yet-another-solution/Blazor.MapLibre/stargazers
[issues-shield]: https://img.shields.io/github/issues/Yet-another-solution/Blazor.MapLibre.svg?style=for-the-badge
[issues-url]: https://github.com/Yet-another-solution/Blazor.MapLibre/issues
[license-shield]: https://img.shields.io/github/license/Yet-another-solution/Blazor.MapLibre.svg?style=for-the-badge
[license-url]: https://github.com/Yet-another-solution/Blazor.MapLibre/blob/master/LICENSE.txt
[nuget-shield]: https://img.shields.io/nuget/v/Community.Blazor.MapLibre.svg?style=for-the-badge
[nuget-url]: https://www.nuget.org/packages/Community.Blazor.MapLibre