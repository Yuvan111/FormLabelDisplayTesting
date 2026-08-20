This repository has a common Blazor web app sample under the Interactivity mode sample; for testing the sample across all render modes, kindly set the below render mode values within the app.razor file.

| Configuration             | How to get it                                                                 |
|---------------------------|-------------------------------------------------------------------------------|
| Static SSR                | No `@rendermode` on the component                                            |
| Interactive Server        | `@rendermode InteractiveServer`                                              |
| Interactive WebAssembly   | `@rendermode InteractiveWebAssembly`, component must live in the `.Client` project |
| Interactive Auto          | `@rendermode InteractiveAuto`, component must live in the `.Client` project  |
