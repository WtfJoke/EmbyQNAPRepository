import groovy.xml.MarkupBuilder

encoding = 'UTF-8'
qnap = [
    version: '4.3.4',
    platforms: [
        'TS-NASX86': 'x86_64',
        'TS-X28A': 'arm_64',
        'TS-X32': 'arm_64',
        'TS-X32U': 'arm_64',
        'TS-XA28A': 'arm_64',
        'TS-X31': 'arm-x31',
    ],
    mono_platforms: [
        'TS-X41': 'arm-x41',
        'TS-ARM-X19': 'arm-x19'
    ]
]

properties = loadProperties()
rootDownloadUrl = properties.'release.download.url'
appVersion = properties.'application.version'
name = properties.'package.name'
repositoryFile = new File('repository.xml')

repositoryFile.withWriter(encoding) { writer ->
    xml = new MarkupBuilder(writer)
    xml.mkp.xmlDeclaration(version: '1.0', encoding: encoding)
    xml.plugins {
        cachechk(new Date().format('yyyyMMddhhmmss'))

        item {
            name(name)
            internalName(name)
            category('Essentials')
            type('Entertainment')
            icon100('https://emby.media/community/uploads/inline/44692/560bd2026cb12_MB3_106_87.png')
            icon80('https://emby.media/community/uploads/inline/44692/560bd22372364_MB3_85_70.png')
            description(properties.'package.description')
            developer('Emby LLC')
            developerLink('https://emby.media/')
            fwVersion(qnap.version)
            version(properties.'application.version')
            qnap.platforms.each { key, value ->
                platform {
                    platformID(key)
                    location("${rootDownloadUrl}/${appVersion}/emby-server-qnap_${appVersion}_${value}.qpkg")
                }
            }
            snapshot('https://emby.media/resources/Screenshot_2015-09-28-22-42-491.png')
            tutorialLink('https://support.emby.media/support/solutions/articles/44001089172-home')
            forumLink('https://emby.media/community/')
        }
    }
}

Properties loadProperties() {
    properties = new Properties()
    propertiesFile = new File('app.properties')
    propertiesFile.withInputStream {
        properties.load(it)
    }
    return properties
}
