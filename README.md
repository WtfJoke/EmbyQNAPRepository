# EmbyQNAPRepository

QNAP Custom App Repository for emby releases.

## 🏋️ Motivation

Since Emby is not yet listed in the official QNAP App Center ([source](https://emby.media/community/index.php?/topic/113735-qnap-emby-repository/#comment-1199816)), the only way to update Emby on a QNAP NAS is to download the newest release from [their page](https://emby.media/qnap-server.html) and upload it manually to your app center.

There is the possibility to add 3rd party repositories in the app center, but emby doesn't provide any. Thats why this project was born.

## 🔨 Run locally

- Install [Groovy](https://groovy.apache.org/download.html)
- Run script: `groovy createRepository.groovy`