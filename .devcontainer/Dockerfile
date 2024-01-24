ARG VARIANT=8.0-bookworm-slim
FROM mcr.microsoft.com/dotnet/sdk:${VARIANT}

ENV PATH $PATH:/home/vscode/.dotnet:/home/vscode/.dotnet/tools

RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
     && apt-get -y install --no-install-recommends graphviz

