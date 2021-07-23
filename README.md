| Builds  | Branch | Status 
| ------------- | -----  |--------
| Circle CI  | main   | [![dof-dss](https://circleci.com/gh/dof-dss/nicts-probate-eligibility-checker.svg?style=svg&circle-token=65bd91969b3a6cb1b6e37eb596224aa2ffddacf9)](https://app.circleci.com/pipelines/github/dof-dss/nicts-probate-eligibility-checker)
| SonarCloud  | main   |  [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=dof-dss_nicts-probate-eligibility-checker&metric=alert_status)](https://sonarcloud.io/dashboard?id=dof-dss_nicts-probate-eligibility-checker)

# nicts-probate-eligibility-checker

## Description
This is a simple eligibility checker for the Probate process. The users hit this first after the main Drupal site.

## Contents of this file

- [Contributing](#contributing)
- [Licensing](#licensing)
- [Project Documentation](#project-documentation)
    - [Why did we build this project](#why-did-we-build-this-project)
    - [What problem was it solving](#what-problem-was-it-solving)
    - [How did we do it](#how-did-we-do-it)
    - [Future Plans](#future-plans)
    - [Deployment Guide](#deployment-guide)

## Contributing

Contributions are welcomed! Read the [Contributing Guide](./docs/contributing/Index.md) for more information.

## Licensing

Unless stated otherwise, the codebase is released under the MIT License. This covers both the codebase and any sample code in the documentation. The documentation is © Crown copyright and available under the terms of the Open Government 3.0 licence.

## Project Documentation

### Why did we build this project?

We built this to streamline the probate process.

### What problem was it solving?

This solves the problem of working out if citizens can apply for probate online in Northern Ireland.

### How did we do it?

This is a simple dotnet core application with the questions hard coded into the site.

### Future plans

This site will be used for a variety of other projects not just Probate. It will be used as an entry point to check eligibility for a certain government service.

### Deployment guide

To build run "dotnet build" in command line then
dotnet run to run the site


