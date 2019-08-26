
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Docker;
using FlubuCore.Tasks.Docker.Builder;
using FlubuCore.Tasks.Docker.Checkpoint;
using FlubuCore.Tasks.Docker.Config;
using FlubuCore.Tasks.Docker.Container;
using FlubuCore.Tasks.Docker.Context;
using FlubuCore.Tasks.Docker.Engine;
using FlubuCore.Tasks.Docker.Image;
using FlubuCore.Tasks.Docker.Manifest;
using FlubuCore.Tasks.Docker.Network;
using FlubuCore.Tasks.Docker.Node;
using FlubuCore.Tasks.Docker.Plugin;
using FlubuCore.Tasks.Docker.Secret;
using FlubuCore.Tasks.Docker.Service;
using FlubuCore.Tasks.Docker.Stack;
using FlubuCore.Tasks.Docker.Swarm;
using FlubuCore.Tasks.Docker.System;
using FlubuCore.Tasks.Docker.Trust;
using FlubuCore.Tasks.Docker.Volume;

namespace FlubuCore.Infrastructure.Terminal
{
    public static class DockerCommands
    {  
        public static Dictionary<string, Type> SupportedExternalProcesses = new Dictionary<string, Type>()
    {{ "docker attach", typeof(DockerAttachTask) },
{ "docker build", typeof(DockerBuildTask) },
{ "docker builder build", typeof(DockerBuilderBuildTask) },
{ "docker builder prune", typeof(DockerBuilderPruneTask) },
{ "docker checkpoint create", typeof(DockerCheckpointCreateTask) },
{ "docker checkpoint ls", typeof(DockerCheckpointLsTask) },
{ "docker checkpoint rm", typeof(DockerCheckpointRmTask) },
{ "docker commit", typeof(DockerCommitTask) },
{ "docker config create", typeof(DockerConfigCreateTask) },
{ "docker config inspect", typeof(DockerConfigInspectTask) },
{ "docker config ls", typeof(DockerConfigLsTask) },
{ "docker container attach", typeof(DockerContainerAttachTask) },
{ "docker container commit", typeof(DockerContainerCommitTask) },
{ "docker container create", typeof(DockerContainerCreateTask) },
{ "docker container exec", typeof(DockerContainerExecTask) },
{ "docker container export", typeof(DockerContainerExportTask) },
{ "docker container inspect", typeof(DockerContainerInspectTask) },
{ "docker container kill", typeof(DockerContainerKillTask) },
{ "docker container logs", typeof(DockerContainerLogsTask) },
{ "docker container ls", typeof(DockerContainerLsTask) },
{ "docker container prune", typeof(DockerContainerPruneTask) },
{ "docker container restart", typeof(DockerContainerRestartTask) },
{ "docker container rm", typeof(DockerContainerRmTask) },
{ "docker container run", typeof(DockerContainerRunTask) },
{ "docker container start", typeof(DockerContainerStartTask) },
{ "docker container stats", typeof(DockerContainerStatsTask) },
{ "docker container stop", typeof(DockerContainerStopTask) },
{ "docker container update", typeof(DockerContainerUpdateTask) },
{ "docker context create", typeof(DockerContextCreateTask) },
{ "docker context export", typeof(DockerContextExportTask) },
{ "docker context inspect", typeof(DockerContextInspectTask) },
{ "docker context ls", typeof(DockerContextLsTask) },
{ "docker context rm", typeof(DockerContextRmTask) },
{ "docker context update", typeof(DockerContextUpdateTask) },
{ "docker create", typeof(DockerCreateTask) },
{ "docker deploy", typeof(DockerDeployTask) },
{ "docker engine activate", typeof(DockerEngineActivateTask) },
{ "docker engine check", typeof(DockerEngineCheckTask) },
{ "docker engine update", typeof(DockerEngineUpdateTask) },
{ "docker events", typeof(DockerEventsTask) },
{ "docker exec", typeof(DockerExecTask) },
{ "docker export", typeof(DockerExportTask) },
{ "docker history", typeof(DockerHistoryTask) },
{ "docker images", typeof(DockerImagesTask) },
{ "docker image build", typeof(DockerImageBuildTask) },
{ "docker image history", typeof(DockerImageHistoryTask) },
{ "docker image import", typeof(DockerImageImportTask) },
{ "docker image inspect", typeof(DockerImageInspectTask) },
{ "docker image load", typeof(DockerImageLoadTask) },
{ "docker image ls", typeof(DockerImageLsTask) },
{ "docker image prune", typeof(DockerImagePruneTask) },
{ "docker image pull", typeof(DockerImagePullTask) },
{ "docker image push", typeof(DockerImagePushTask) },
{ "docker image rm", typeof(DockerImageRmTask) },
{ "docker image save", typeof(DockerImageSaveTask) },
{ "docker import", typeof(DockerImportTask) },
{ "docker info", typeof(DockerInfoTask) },
{ "docker inspect", typeof(DockerInspectTask) },
{ "docker kill", typeof(DockerKillTask) },
{ "docker load", typeof(DockerLoadTask) },
{ "docker login", typeof(DockerLoginTask) },
{ "docker logs", typeof(DockerLogsTask) },
{ "docker manifest annotate", typeof(DockerManifestAnnotateTask) },
{ "docker manifest create", typeof(DockerManifestCreateTask) },
{ "docker manifest inspect", typeof(DockerManifestInspectTask) },
{ "docker manifest push", typeof(DockerManifestPushTask) },
{ "docker network connect", typeof(DockerNetworkConnectTask) },
{ "docker network create", typeof(DockerNetworkCreateTask) },
{ "docker network disconnect", typeof(DockerNetworkDisconnectTask) },
{ "docker network inspect", typeof(DockerNetworkInspectTask) },
{ "docker network ls", typeof(DockerNetworkLsTask) },
{ "docker network prune", typeof(DockerNetworkPruneTask) },
{ "docker node inspect", typeof(DockerNodeInspectTask) },
{ "docker node ls", typeof(DockerNodeLsTask) },
{ "docker node ps", typeof(DockerNodePsTask) },
{ "docker node rm", typeof(DockerNodeRmTask) },
{ "docker node update", typeof(DockerNodeUpdateTask) },
{ "docker plugin create", typeof(DockerPluginCreateTask) },
{ "docker plugin disable", typeof(DockerPluginDisableTask) },
{ "docker plugin enable", typeof(DockerPluginEnableTask) },
{ "docker plugin inspect", typeof(DockerPluginInspectTask) },
{ "docker plugin install", typeof(DockerPluginInstallTask) },
{ "docker plugin ls", typeof(DockerPluginLsTask) },
{ "docker plugin push", typeof(DockerPluginPushTask) },
{ "docker plugin rm", typeof(DockerPluginRmTask) },
{ "docker plugin upgrade", typeof(DockerPluginUpgradeTask) },
{ "docker ps", typeof(DockerPsTask) },
{ "docker pull", typeof(DockerPullTask) },
{ "docker push", typeof(DockerPushTask) },
{ "docker restart", typeof(DockerRestartTask) },
{ "docker rm", typeof(DockerRmTask) },
{ "docker rmi", typeof(DockerRmiTask) },
{ "docker run", typeof(DockerRunTask) },
{ "docker save", typeof(DockerSaveTask) },
{ "docker search", typeof(DockerSearchTask) },
{ "docker secret create", typeof(DockerSecretCreateTask) },
{ "docker secret inspect", typeof(DockerSecretInspectTask) },
{ "docker secret ls", typeof(DockerSecretLsTask) },
{ "docker service create", typeof(DockerServiceCreateTask) },
{ "docker service inspect", typeof(DockerServiceInspectTask) },
{ "docker service logs", typeof(DockerServiceLogsTask) },
{ "docker service ls", typeof(DockerServiceLsTask) },
{ "docker service ps", typeof(DockerServicePsTask) },
{ "docker service rollback", typeof(DockerServiceRollbackTask) },
{ "docker service scale", typeof(DockerServiceScaleTask) },
{ "docker service update", typeof(DockerServiceUpdateTask) },
{ "docker stack", typeof(DockerStackTask) },
{ "docker stack deploy", typeof(DockerStackDeployTask) },
{ "docker stack ls", typeof(DockerStackLsTask) },
{ "docker stack ps", typeof(DockerStackPsTask) },
{ "docker stack rm", typeof(DockerStackRmTask) },
{ "docker stack services", typeof(DockerStackServicesTask) },
{ "docker start", typeof(DockerStartTask) },
{ "docker stats", typeof(DockerStatsTask) },
{ "docker stop", typeof(DockerStopTask) },
{ "docker swarm ca", typeof(DockerSwarmCaTask) },
{ "docker swarm init", typeof(DockerSwarmInitTask) },
{ "docker swarm join-token", typeof(DockerSwarmJoinTokenTask) },
{ "docker swarm join", typeof(DockerSwarmJoinTask) },
{ "docker swarm leave", typeof(DockerSwarmLeaveTask) },
{ "docker swarm unlock-key", typeof(DockerSwarmUnlockKeyTask) },
{ "docker swarm update", typeof(DockerSwarmUpdateTask) },
{ "docker system df", typeof(DockerSystemDfTask) },
{ "docker system events", typeof(DockerSystemEventsTask) },
{ "docker system info", typeof(DockerSystemInfoTask) },
{ "docker system prune", typeof(DockerSystemPruneTask) },
{ "docker trust inspect", typeof(DockerTrustInspectTask) },
{ "docker trust key generate", typeof(DockerTrustKeyGenerateTask) },
{ "docker trust key load", typeof(DockerTrustKeyLoadTask) },
{ "docker trust revoke", typeof(DockerTrustRevokeTask) },
{ "docker trust sign", typeof(DockerTrustSignTask) },
{ "docker trust signer add", typeof(DockerTrustSignerAddTask) },
{ "docker trust signer remove", typeof(DockerTrustSignerRemoveTask) },
{ "docker update", typeof(DockerUpdateTask) },
{ "docker version", typeof(DockerVersionTask) },
{ "docker volume create", typeof(DockerVolumeCreateTask) },
{ "docker volume inspect", typeof(DockerVolumeInspectTask) },
{ "docker volume ls", typeof(DockerVolumeLsTask) },
{ "docker volume prune", typeof(DockerVolumePruneTask) },
{ "docker volume rm", typeof(DockerVolumeRmTask) },
};      
    }
}

