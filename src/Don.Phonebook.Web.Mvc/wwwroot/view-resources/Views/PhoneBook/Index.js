(function($) {

    var personService = abp.services.app.person;
    var $modal = $("#PersonCreateModal");
    var $form = $modal.find("form");

/*    _$form.validate({
        rules: {
            Password: "required",
            ConfirmPassword: {
                equalTo: "#Password"
            }
        }
    });*/

    //Handle save button click
    $form.closest("div.modal-content").find(".save-button").click(function(e) {
        e.preventDefault();
        save();
    });
    //replaced by $form.closest
/*    $form.find('button[type="submit"]').click(function(e) {
        e.preventDefault();
        save();
    }); */

    $modal.on("shown.bs.modal", function() {
        $modal.find("input:not([type=hidden]):first").focus();
    });

    $("#RefreshButton").click(function() {
        refreshUserList();
    });

    function refreshUserList() {
        location.reload(true); //reload page to see new user!
    }

    function save() {
        if (!$form.valid()) {
            return;
        }

        var person = $form.serializeFormToObject();
        abp.ui.setBusy($modal);

        personService.createPerson(person).done(function() {
           // $modal.modal.hide("hide");
            $modal.modal('hide');
            location.reload(true); //reload page to see new person!
        }).always(function() {
            abp.ui.clearBusy($modal);
        });
    }

    //Handle enter key
/*    $form.find('input').on('keypress', function (e) {
        if (e.which === 13) {
            e.preventDefault();
            save();
        }
    });*/

    //$.AdminBSB.input.activate(_$form); //When we lazy load an HTML content, we need to re-call $.AdminBSB.input.activate(); in order to make material floating inputs working.https://github.com/gurayyarar/AdminBSBMaterialDesign/pull/61

/*    function deleteUser(userId, userName) {
        abp.message.confirm(
            "Delete user '" + userName + "'?",
            function (isConfirmed) {
                if (isConfirmed) {
                    _userService.delete({
                        id: userId
                    }).done(function () {
                        refreshUserList();
                    });
                }
            }
        );
    }*/
})(jQuery);

/*ASPZERO MODALMANAGER Version*/
/*    var _createPersonModal = new app.ModalManager({
        viewUrl: abp.appPath + 'App/PhoneBook/CreatePersonModal',
        scriptUrl: abp.appPath + 'view-resources/Areas/App/Views/PhoneBook/_CreatePersonModal.js',
        modalClass: 'CreatePersonModal'
    });

    $('#CreateNewPersonButton').click(function (e) {
        e.preventDefault();
        _createPersonModal.open();
    });*/