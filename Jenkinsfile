pipeline {
  agent any
 
  stages {
    stage('foo') {
      steps {
        tool(docker:'docker')
        sh "docker version" // DOCKER_CERT_PATH is automatically picked up by the Docker client
      }
    }
  }
}
