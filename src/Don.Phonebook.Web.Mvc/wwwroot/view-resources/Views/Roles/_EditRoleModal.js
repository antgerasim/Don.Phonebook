(function($) {
    debugger;
    var _roleService = abp.services.app.role;
    var _$modal = $('#RoleEditModal');
    var _$form = $('form[name=RoleEditForm]');

    function save() {

        if (!_$form.valid()) {
            return;
        }

        var role = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js
        role.permissions = [];
        var _$permissionCheckboxes = $("input[name='permission']:checked:visible");
        if (_$permissionCheckboxes) {
            for (var permissionIndex = 0; permissionIndex < _$permissionCheckboxes.length; permissionIndex++) {
                var _$permissionCheckbox = $(_$permissionCheckboxes[permissionIndex]);
                role.permissions.push(_$permissionCheckbox.val());
            }
        }

        abp.ui.setBusy(_$form);
        _roleService.update(role)
            .done(function() {
                _$modal.modal('hide');
                location.reload(true); //reload page to see edited role!
            })
            .always(function() {
                abp.ui.clearBusy(_$modal);
            });
    }



    $('input:checkbox[name=permission]').each(function () {
          
            console.log('fickenIn');
            $(this).click(function (e) {
                console.log("Ficken");
                console.log(e.currentTarget.checked);
                //debugger;
                var test = $(e.currentTarget).prop("checked", true);
                test.prop("checked", true);

            });
    });

/*    $('.checkInp input:checkbox')
        .on('click',
            function(e) {

                // prevents the event from bubbling up the DOM tree
                // eg the modal from cancelling the event
                e.stopImmediatePropagation();

                var checked = (e.currentTarget.checked) ? false : true;
                e.currentTarget.checked = (checked) ? false : checked.toString();
            });*/



    //Handle save button click
    _$form.closest('div.modal-content')
        .find(".save-button")
        .click(function(e) {
            e.preventDefault();
            save();
        });

    //Handle enter key
    _$form.find('input')
        .on('keypress',
            function(e) {
                if (e.which === 13) {
                    e.preventDefault();
                    save();
                }
            });

    $.AdminBSB.input.activate(_$form);

    _$modal.on('shown.bs.modal',
        function() {
            _$form.find('input[type=text]:first').focus();
        });
})(jQuery);