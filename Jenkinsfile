pipeline {
    agent any
    stages {
        stage('Test') {
            steps {
                tool 'docker'
                sh 'docker pull microsoft/dotnet:2.1-sdk'
                docker.image('microsoft/dotnet:2.1-sdk').inside {
                    git credentialsId: 'Github', url: 'https://github.com/ashwinizanzad31/dotnet-demo.git'}
                    sh 'dotnet build'
      
            }
        }
    }
}
